using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dashboard.DataAccess.Concrete;
using Dashboard.Business.Concrete;
using Dashboard.DataAccess.Concrete.Mysql;
using Dashboard.Business.Abtract;
using Dashboard.Entities.Concrete;
using NodaTime;

namespace Dashboard.WinFormsUI.UserControls
{
    public partial class AnaSayfa : UserControl
    {
        public Machine Machine { get; set; }
        int a = 0;
        public List<Machine> _machines = new List<Machine>();
        public List<Category> _categories = new List<Category>();
        public List<GroupBox> _gbs = new List<GroupBox>();
        public List<Label> _lblListAcik = new List<Label>();
        public List<Label> _lblListKapali = new List<Label>();
        public List<Label> _lblListCalismaSuresi = new List<Label>();
        public List<TextBox> _tbWorkOrderNo = new List<TextBox>();
        public List<string> _gbName = new List<string>();
        private IMachineService _machineService;
        private ICategoryService _categoryService;
        private ILogService _logService;
        private IWorkOrderStateService _workOrderStateService;
        private string _serverIp="172.16.0.221";
        private string _serverDb = "Backup";
        private string _raspiDb = "Machine";
        private string _raspiTable = "Logs";
        private int _ctgId = 0;

        public AnaSayfa()
        {
            InitializeComponent();
            _machineService = new MachineManager(new MysqlMachineDal());
            _categoryService = new CategoryManager(new MysqlCategoryDal());
            _logService = new LogManager(new MysqlLogDal());
            _workOrderStateService = new WorkOrderStateManager(new MysqlWorkOrderStateDal());
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            panelSeperator.BackColor = Color.FromArgb(200, 185, 0);
            panelSeperator2.BackColor = Color.FromArgb(200, 185, 0);
            PieChart();
            timerDbCheck.Interval = 1000;
            timerDbCheck.Enabled = true;
            timerDbCheck.Start();
            DbCheck();
            WorkOrders();
            lblMakine.Text = Machine.MachineName;
           

        }
        private List<Machine> GetAllMachines()
        {
            return _machineService.GetAll();
        }
        public void WorkOrders()
        {

            WorkOrderState wos = new WorkOrderState();
            wos = _workOrderStateService.GetLast(Machine);
            if (wos.Id == 0)
            {
                lblWorkOrder.Text = "Bu Makinede İş Emri Bulunamadı";
            }
            else
            {
                bool isWorkOrderFinish = _workOrderStateService.IsWorkOrderFinish(Machine, wos.WorkOrderNo);
                if (isWorkOrderFinish)
                {
                    List<WorkOrderState> workOrderStates = new List<WorkOrderState>();
                    workOrderStates = _workOrderStateService.GetByWorkOrderNo(Machine, wos.WorkOrderNo);
                    DateTime start = workOrderStates[1].Date;
                    DateTime finish = workOrderStates[0].Date;
                    TimeSpan duration = finish - start;
                    string wo = string.Format("{0}numaralı iş emri {1} tarihinde başladı {2} tarihinde bitti {3} zaman aldı", wos.WorkOrderNo, start, finish, duration);
                    lblWorkOrder.Text = wo;
                    int startId = workOrderStates[0].Id;
                    int finishId = workOrderStates[1].Id;
                    //dgvWorkOrdersDetails.DataSource = _logService.GetById(Machine.Ip, "Machine", "Logs", startId, finishId);
                }
                else
                {

                    List<WorkOrderState> workOrderStates = new List<WorkOrderState>();
                    workOrderStates = _workOrderStateService.GetByWorkOrderNo(Machine, wos.WorkOrderNo);
                    int startId = workOrderStates[0].Id;
                    DateTime start = workOrderStates[0].Date;
                    string wo = string.Format("{0} tarihinde başlayan {1}  numaralı iş emri hala devam ediyor", start, wos.WorkOrderNo);
                    lblWorkOrder.Text = wo;
                    //dgvWorkOrdersDetails.DataSource = _logService.GetById(Machine.Ip, "Machine", "Logs", startId, 0);
                }
            }
            
        }
        public void PieChart()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            double openHours1 = _logService.SpendTime(Machine.Ip, _raspiDb, _raspiTable, date, "open").TotalHours;
            double closeHours1 = _logService.SpendTime(Machine.Ip, _raspiDb, _raspiTable, date, "close").TotalHours;


            double oDay = (openHours1 / (openHours1 + closeHours1)) * 100;
            double cDay = (closeHours1 / (openHours1 + closeHours1)) * 100;
            oDay = (double)System.Math.Round(oDay, 2);
            cDay = (double)System.Math.Round(cDay, 2);

            pieDay.Series["Series1"].Points.Clear();
            pieDay.Titles.Add("Günlük Verim");
            pieDay.Series["Series1"].Points.AddXY("open %" + oDay.ToString(), oDay);
            pieDay.Series["Series1"].Points.AddXY("close %" + cDay.ToString(), cDay);
        }
        private void AnaSayfa_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                timerDbCheck.Enabled = false;
                timerDbCheck.Stop();
            }   
        }
        public void DbCheck()
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string acik = _logService.SpendTime(Machine.Ip, "Machine", "Logs", date, "open").ToString();
            string kapali = _logService.SpendTime(Machine.Ip, "Machine", "Logs", date, "close").ToString();
            lblAcik.Text = string.Format("Açık : {0}", acik);
            lblKapali.Text = string.Format("Kapalı : {0}", kapali);

            Log lastLog = new Log();
            lastLog = _logService.GetLast(Machine.Ip, "Machine", "Logs");
            string lastState = lastLog.LastState;
            pbState.Image = (lastState == "open") ? Properties.Resources.green : Properties.Resources.red;
            lastState = (lastState == "open") ? "'dir açık" : "'dir kapalı";
            var lastTime = lastLog.LastDate;
            var gecenSure = DateTime.Now - lastTime;

            string calismaSuresi = string.Format("{0:%d}g {0:%h}s {0:%m}dk {0:%s}sn", gecenSure) + "\t" + lastState;
            lblTime.Text = calismaSuresi;


        }
        private void timerDbCheck_Tick(object sender, EventArgs e)
        {
            DbCheck();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbWorkOrderNo.Text
                ))
            {
                Machine machine = Machine;

                Log lastLog = _logService.GetLastLog(machine.Ip, _raspiDb, "Logs");
                TimeSpan time = DateTime.Now.Subtract(lastLog.Date);
                Log log = new Log
                {
                    Name = lastLog.Name,
                    LastState = lastLog.State,
                    LastDate = lastLog.Date,
                    State = lastLog.State,
                    Time = time,
                    Shift = lastLog.Shift
                };
                _logService.Add(log, machine);
                int id = lastLog.Id + 1;
                string workOrderNo = tbWorkOrderNo.Text;
                WorkOrderState workOrderState = new WorkOrderState
                {
                    Id = id,
                    WorkOrderNo = workOrderNo,
                    State = "start"
                };
                _workOrderStateService.Add(workOrderState, machine);
                tbWorkOrderNo.Text = "";
            }
        }
    }
}
