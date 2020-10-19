namespace Dashboard.WinFormsUI.UserControls
{
    partial class MakineSecim
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMachineName = new System.Windows.Forms.TextBox();
            this.btnSec = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMachine = new System.Windows.Forms.DataGridView();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachine)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMachineName
            // 
            this.tbMachineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMachineName.Location = new System.Drawing.Point(329, 394);
            this.tbMachineName.Name = "tbMachineName";
            this.tbMachineName.Size = new System.Drawing.Size(200, 38);
            this.tbMachineName.TabIndex = 0;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(372, 474);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(107, 50);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.tbMachineName);
            this.panelMain.Controls.Add(this.btnSec);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(875, 720);
            this.panelMain.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMachine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 338);
            this.panel1.TabIndex = 2;
            // 
            // dgvMachine
            // 
            this.dgvMachine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMachine.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMachine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMachine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMachine.GridColor = System.Drawing.SystemColors.Control;
            this.dgvMachine.Location = new System.Drawing.Point(0, 0);
            this.dgvMachine.Name = "dgvMachine";
            this.dgvMachine.Size = new System.Drawing.Size(875, 338);
            this.dgvMachine.TabIndex = 0;
            this.dgvMachine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMachine_CellClick);
            // 
            // MakineSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "MakineSecim";
            this.Size = new System.Drawing.Size(875, 720);
            this.Load += new System.EventHandler(this.MakineSecim_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMachine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbMachineName;
        private System.Windows.Forms.Button btnSec;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMachine;
    }
}
