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
using Dashboard.Business.Abtract;
using Dashboard.DataAccess.Concrete.Mysql;
using Dashboard.Business.Concrete;
using Dashboard.Entities.Concrete;

namespace Dashboard.WinFormsUI.UserControls
{
    public partial class AnaSayfaWarning : UserControl
    {
        public Machine Machine { get; set; }
        public List<Machine> _machines = new List<Machine>();
        public List<Category> _categories = new List<Category>();
        private IMachineService _machineService;
        private ICategoryService _categoryService;
        private ILogService _logService;
        private IWorkOrderStateService _workOrderStateService;
        private IStopReasonService _stopReasonService;
        private string _raspiDb = "Machine";
        private string _raspiTable = "Logs";
        public AnaSayfaWarning()
        {
            InitializeComponent();
            _machineService = new MachineManager(new MysqlMachineDal());
            _categoryService = new CategoryManager(new MysqlCategoryDal());
            _logService = new LogManager(new MysqlLogDal());
            _workOrderStateService = new WorkOrderStateManager(new MysqlWorkOrderStateDal());
            _stopReasonService = new StopReasonManager(new MysqlStopReasonDal());
        }

        private void AnaSayfaWarning_Load(object sender, EventArgs e)
        {
            panelSeperator2.BackColor = Color.FromArgb(0, 77, 64);
            PieChart();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
            DbCheck();
            lblMakine.Text = Machine.MachineName;
            pbState.Image = Properties.Resources.warning;
        }
        private List<Machine> GetAllMachines()
        {
            return _machineService.GetAll();
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
        public void DbCheck()
        {
            Console.WriteLine("dbcheck fired");
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
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbStopCode.Text))
            {

                Log log = new Log();
                log = _logService.GetLast(Machine.Ip, _raspiDb, _raspiTable);
                TimeSpan time =  DateTime.Now - log.Date;
                string exp = "";
                int id;
               
                if (!string.IsNullOrWhiteSpace(rtbExp.Text))
                {
                    exp = rtbExp.Text;
                }
                StopReason sr = new StopReason
                {
                    Start = log.Date,
                    Finish = DateTime.Now,
                    Time = time,
                    Reason = Int32.Parse(tbStopCode.Text.ToString())
                };

                
            AnaSayfa anaSayfa = new AnaSayfa
            {
                Machine = Machine,
                StopMinute = 35
            };
                timer.Enabled = false;
                timer.Stop();
                panelMain.Controls.Clear();
                panelMain.Controls.Add(anaSayfa);
                anaSayfa.Show();
                anaSayfa.Dock = DockStyle.Fill;
                anaSayfa.BringToFront();
            }
           
           
        }

        private void AnaSayfaWarning_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                timer.Enabled = false;
                timer.Stop();
            }
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            Console.WriteLine("timer tick waring");
            DbCheck();
        }
    }
}
