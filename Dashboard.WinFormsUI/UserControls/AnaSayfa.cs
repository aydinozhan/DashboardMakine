﻿using System;
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
            //Control.CheckForIllegalCrossThreadCalls = false;
            //Console.WriteLine("ana sayfa load fired");
            //_categories = _categoryService.GetAll();
            //cbCategories.DataSource = _categories;
            //cbCategories.DisplayMember = "CategoryName";
            //cbCategories.ValueMember = "CategoryId";
            //cbCategories.SelectedValue = _categoryService.GetIdByName("Hepsi");
            //dtp.Format = DateTimePickerFormat.Custom;
            //CreateGb(GetAllMachines());
            //FillGb(GetAllMachines());
            //_ctgId = _categoryService.GetIdByName("Hepsi");
            //timerDbCheck.Interval = 1000;
            //timerDbCheck.Enabled = true;
            //timerDbCheck.Start();
        }
        private List<Machine> GetAllMachines()
        {
            return _machineService.GetAll();
        }
        public void CreateGb(List<Machine> machines)
        {
            Console.WriteLine("CreateGb()");
            a = 0;
            _gbs.Clear();
            _gbName.Clear();
            panelGbs.Controls.Clear();
            _lblListAcik.Clear();
            _lblListKapali.Clear();
            _lblListCalismaSuresi.Clear();
            _tbWorkOrderNo.Clear();
            for (int i = 0; i < machines.Count; i++)
            {
                GroupBox gb = new GroupBox();
                gb.Name = machines[i].MachineName;
                gb.Size = new Size(200, 250);
                gb.Text = machines[i].MachineName + " " + machines[i].Ip;
                gb.Font = new Font("Segoe UI", 12);
                gb.FlatStyle = FlatStyle.Popup;
                gb.BackColor = (i % 2 == 0) ? Color.FromArgb(166, 162, 229) : Color.FromArgb(149, 198, 255);
                _gbs.Add(gb);
                panelGbs.Controls.Add(gb);
                _gbName.Add(gb.Name);
            }
            for (int i = 0; i < machines.Count; i++)
            {
                int idx = _gbName.IndexOf(machines[i].MachineName);
                GroupBox gb = _gbs[idx];

                Label lblopen = new Label();
                lblopen.Name = "lbl1";
                lblopen.Text = "Açık";
                lblopen.Size = new Size(50, 17);
                lblopen.Font = new Font("Arial", 10);
                lblopen.Location = new Point(10, 55);
                gb.Controls.Add(lblopen);

                Label lblAcik = new Label();
                lblAcik.Name = "labelacik" + machines[i].MachineName;
                lblAcik.Text = "Açık geçen zaman";
                lblAcik.Size = new Size(120, 17);
                lblAcik.Font = new Font("Arial", 10);
                lblAcik.Location = new Point(80, 55);
                gb.Controls.Add(lblAcik);
                _lblListAcik.Add(lblAcik);

                Label lblclose = new Label();
                lblclose.Name = "lbl2";
                lblclose.Text = "Kapalı";
                lblclose.Size = new Size(50, 17);
                lblclose.Font = new Font("Arial", 10);
                lblclose.Location = new Point(10, 75);
                gb.Controls.Add(lblclose);

                Label lblKapali = new Label();
                lblKapali.Name = "labelkapali" + machines[i].MachineName;
                lblKapali.Text = "Kapalı";
                lblKapali.Size = new Size(120, 17);
                lblKapali.Font = new Font("Arial", 10);
                lblKapali.Location = new Point(80, 75);
                gb.Controls.Add(lblKapali);
                _lblListKapali.Add(lblKapali);

                Label lblCalismaSuresi = new Label();
                lblCalismaSuresi.Name = "labelCalismaSuresi";
                lblCalismaSuresi.Text = "çalışma süresi";
                lblCalismaSuresi.Size = new Size(150, 50);
                lblCalismaSuresi.Font = new Font("Arial", 10);
                lblCalismaSuresi.Location = new Point(10,100);
                gb.Controls.Add(lblCalismaSuresi);
                _lblListCalismaSuresi.Add(lblCalismaSuresi);

                TextBox tbWorkOrderNo = new TextBox();
                lblCalismaSuresi.Name = i.ToString();
                tbWorkOrderNo.Size = new Size(180,20);
                tbWorkOrderNo.Location = new Point(10,150);
                _tbWorkOrderNo.Add(tbWorkOrderNo);
                gb.Controls.Add(tbWorkOrderNo);

                Button btn1 = new Button();
                btn1.Name = i.ToString();
                btn1.Text = "Detay";
                btn1.Size = new Size(70, 30);
                btn1.Location = new Point(65, 215);
                btn1.FlatStyle = FlatStyle.Flat;
                btn1.FlatAppearance.BorderSize = 0;
                btn1.BackColor = (i % 2 == 0) ? Color.FromArgb(118, 115, 179) : Color.FromArgb(98, 150, 204);
                btn1.Dock = DockStyle.Bottom;
                btn1.Click += new EventHandler(this.btn_click);
                gb.Controls.Add(btn1);

                Button btnBasla = new Button();
                btnBasla.Name = i.ToString();
                btnBasla.Text = "Başlat";
                btnBasla.Size = new Size(60, 30);
                btnBasla.Location = new Point(5, 180);
                btnBasla.FlatStyle = FlatStyle.Flat;
                btnBasla.FlatAppearance.BorderSize = 0;
                btnBasla.BackColor = Color.FromArgb(102, 187, 106);
                btnBasla.Click += new EventHandler(this.btnBasla_click);
                gb.Controls.Add(btnBasla);

                Button btnWorkOrders = new Button();
                btnWorkOrders.Name = i.ToString();
                btnWorkOrders.Text = "İşEmirleri";
                btnWorkOrders.Size = new Size(60, 30);
                btnWorkOrders.Location = new Point(70, 180);
                btnWorkOrders.FlatStyle = FlatStyle.Flat;
                btnWorkOrders.Font = new Font("Arial",8);
                btnWorkOrders.FlatAppearance.BorderSize = 0;
                btnWorkOrders.BackColor = Color.FromArgb(84, 110, 122);
                btnWorkOrders.Click += new EventHandler(this.btnWorkOrders_click);
                gb.Controls.Add(btnWorkOrders);

                Button btnBitir = new Button();
                btnBitir.Name = i.ToString();
                btnBitir.Text = "Bitir";
                btnBitir.Size = new Size(60, 30);
                btnBitir.Location = new Point(135, 180);
                btnBitir.FlatStyle = FlatStyle.Flat;
                btnBitir.FlatAppearance.BorderSize = 0;
                btnBitir.BackColor =  Color.FromArgb(229, 57, 53);
                btnBitir.Click += new EventHandler(this.btnBitir_click);
                gb.Controls.Add(btnBitir);

                a += 1;
            }
        }

        private void btnWorkOrders_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = Convert.ToInt32(btn.Name.ToString());
            List<Machine> machines = new List<Machine>();
            machines = GetMachines();
            IsEmirleri im = new IsEmirleri
            {
                Machine = machines[index]
            };
            timerDbCheck.Enabled = false;
            timerDbCheck.Stop();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(im);
            im.Show();
            im.Dock = DockStyle.Fill;
            im.BringToFront();
        }

        private void btnBitir_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = Convert.ToInt32(btn.Name.ToString());
            if (!string.IsNullOrWhiteSpace(_tbWorkOrderNo[index].Text))
            {
                List<Machine> machines = new List<Machine>();
                machines = GetMachines();
                Machine machine = machines[index];

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
                string workOrderNo = _tbWorkOrderNo[index].Text;
                WorkOrderState workOrderState = new WorkOrderState
                {
                    Id = id,
                    WorkOrderNo = workOrderNo,
                    State = "finish"
                };
                _workOrderStateService.Add(workOrderState, machine);
                _tbWorkOrderNo[index].Text = "";

            }

        }

        private void btnBasla_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = Convert.ToInt32(btn.Name.ToString());
            if (!string.IsNullOrWhiteSpace(_tbWorkOrderNo[index].Text))
            {
                List<Machine> machines = new List<Machine>();
                machines = GetMachines();
                Machine machine = machines[index];

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
                string workOrderNo = _tbWorkOrderNo[index].Text;
                WorkOrderState workOrderState = new WorkOrderState
                {
                    Id = id,
                    WorkOrderNo = workOrderNo,
                    State = "start"
                };
                _workOrderStateService.Add(workOrderState, machine);
                _tbWorkOrderNo[index].Text = "";
            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = Convert.ToInt32(btn.Name.ToString());
           
            List<Machine> machines = new List<Machine>();
            machines = GetMachines();           
            Detay dt = new Detay
            {
                Machine = machines[index]
            };
            timerDbCheck.Enabled = false;
            timerDbCheck.Stop();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(dt);
            dt.Show();
            dt.Dock = DockStyle.Fill;
            dt.BringToFront();
        }
        public void FillGb(List<Machine> machines)
        {
            Console.WriteLine("FillGb");
            string date = dtp.Value.ToString("yyyy-MM-dd");
            for (int i = 0; i < (machines.Count); i++)
            {
                string acik =  _logService.SpendTime(machines[i].Ip, "Machine", "Logs", date, "open").ToString();
                string kapali =_logService.SpendTime(machines[i].Ip, "Machine", "Logs", date, "close").ToString();
                Log lastLog = new Log();
                lastLog = _logService.GetLast(machines[i].Ip,"Machine","Logs");
                string lastState =lastLog.LastState;
                lastState = (lastState=="open") ? "'dir açık" : "'dir kapalı";
                var lastTime = lastLog.LastDate;
                var gecenSure = DateTime.Now - lastTime;
                
                string calismaSuresi = string.Format("{0:%d}g {0:%h}s {0:%m}dk {0:%s}sn", gecenSure)+"\t"+lastState;
                if (acik!="01:01:01")
                {
                    _lblListAcik[i].Text = acik;
                    _lblListKapali[i].Text = kapali;
                    _lblListCalismaSuresi[i].Text = calismaSuresi;
                }
                else
                {
                    _lblListAcik[i].Text = "Bağlantı Yok";
                    _lblListKapali[i].Text = "Bağlantı Yok";
                    _lblListCalismaSuresi[i].Text = "Bağlantı Yok";
                }
            }
        }
        private int GetCurrentCtgId()
        {
            int ctgId;
            string s = cbCategories.SelectedValue.ToString();
            bool parseIsSuccesful = int.TryParse(s, out ctgId);
            if (parseIsSuccesful)
            {
                return ctgId;
            }
            else
            {
                return _categoryService.GetIdByName("Hepsi");
            }

        }
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            List<Machine> machines = new List<Machine>();
            machines.Clear();
            machines = GetMachines();
            string theDate = dtp.Value.ToString("yyyy-MM-dd");
            for (int i = 0; i < machines.Count; i++)
            {
                if (DateTime.Today.ToString("yyy-MM-dd") == theDate)
                {
                    timerDbCheck.Enabled = true;
                    timerDbCheck.Start();

                    string acik = _logService.SpendTime(machines[i].Ip, _raspiDb, _raspiTable, theDate, "open").ToString();
                    string kapali = _logService.SpendTime(machines[i].Ip, _raspiDb, _raspiTable, theDate, "close").ToString();
                    _lblListAcik[i].Text = acik;
                    _lblListKapali[i].Text = kapali;
                }
                else
                {
                    
                    timerDbCheck.Enabled = false;
                    timerDbCheck.Stop();

                    string acik = _logService.SpendTime(_serverIp, _serverDb,machines[i].MachineName, theDate, "open").ToString();
                    string kapali = _logService.SpendTime(machines[i].Ip, "Machine", "Logs", theDate, "close").ToString();
                    _lblListAcik[i].Text = acik;
                    _lblListKapali[i].Text = kapali;
                    _lblListCalismaSuresi[i].Text = "";
                }
            }
        }

        private void cbCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            panelGbs.Controls.Clear();
            List<Machine> machines = new List<Machine>();
            machines = GetMachines();
            CreateGb(machines);
            FillGb(machines);
            _ctgId = GetCurrentCtgId();
        }
        private List<Machine> GetMachines()
        {
            int ctgId = GetCurrentCtgId();
            if (ctgId == _categoryService.GetIdByName("Hepsi"))
            {
                return _machineService.GetAll();
            }
            else
            {
                return _machineService.GetByCategoryId(ctgId);
            }
        }
        private void timerDbCheck_Tick(object sender, EventArgs e)
        {
            if (GetCurrentCtgId()!=_ctgId)
            {
                _ctgId = GetCurrentCtgId();
                CreateGb(GetMachines());
                FillGb(GetMachines());
            }
            else
            {
                if (GetMachines().Count!=0)
                {
                    FillGb(GetMachines());
                }
            }
        }

        private void AnaSayfa_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                timerDbCheck.Enabled = false;
                timerDbCheck.Stop();
            }
        }
    }
}
