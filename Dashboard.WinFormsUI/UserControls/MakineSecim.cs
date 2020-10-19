using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dashboard.Business.Abtract;
using Dashboard.Business.Concrete;
using Dashboard.DataAccess.Concrete.Mysql;
using Dashboard.DataAccess.Concrete;

namespace Dashboard.WinFormsUI.UserControls
{
    public partial class MakineSecim : UserControl
    {
        private IMachineService _machineService;
        public MakineSecim()
        {
            InitializeComponent();
            _machineService = new MachineManager(new MysqlMachineDal());
        }

        private void MakineSecim_Load(object sender, EventArgs e)
        {
            dgvMachine.DataSource = _machineService.GetAll();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbMachineName.Text))
            {
                Machine machine = _machineService.GetByName(tbMachineName.Text);
                AnaSayfa anaSayfa = new AnaSayfa { Machine = machine };
                panelMain.Controls.Clear();
                panelMain.Controls.Add(anaSayfa);
                anaSayfa.Show();
                anaSayfa.Dock = DockStyle.Fill;
                anaSayfa.BringToFront();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Makine Seçiniz");
            }
        }

        private void dgvMachine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMachineName.Text = dgvMachine.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
