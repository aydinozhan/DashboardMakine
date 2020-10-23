namespace Dashboard.WinFormsUI.UserControls
{
    partial class AnaSayfa
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelMain = new System.Windows.Forms.Panel();
            this.dgvWorkOrderStates = new System.Windows.Forms.DataGridView();
            this.panelSeperator2 = new System.Windows.Forms.Panel();
            this.panelWorOrders = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbWorkOrderNo = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnBitir = new System.Windows.Forms.Button();
            this.btnWorkOrders = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.lblWorkOrder = new System.Windows.Forms.Label();
            this.panelSeperator = new System.Windows.Forms.Panel();
            this.panelDurum = new System.Windows.Forms.Panel();
            this.pieDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblKapali = new System.Windows.Forms.Label();
            this.lblAcik = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDurum = new System.Windows.Forms.Label();
            this.pbState = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMakine = new System.Windows.Forms.Label();
            this.timerDbCheck = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrderStates)).BeginInit();
            this.panelWorOrders.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelDurum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieDay)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.dgvWorkOrderStates);
            this.panelMain.Controls.Add(this.panelSeperator2);
            this.panelMain.Controls.Add(this.panelWorOrders);
            this.panelMain.Controls.Add(this.panelDurum);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(875, 720);
            this.panelMain.TabIndex = 0;
            // 
            // dgvWorkOrderStates
            // 
            this.dgvWorkOrderStates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkOrderStates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWorkOrderStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkOrderStates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorkOrderStates.Location = new System.Drawing.Point(0, 505);
            this.dgvWorkOrderStates.Name = "dgvWorkOrderStates";
            this.dgvWorkOrderStates.Size = new System.Drawing.Size(875, 215);
            this.dgvWorkOrderStates.TabIndex = 4;
            this.dgvWorkOrderStates.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkOrderStates_CellClick);
            this.dgvWorkOrderStates.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvWorkOrderStates_DataBindingComplete);
            // 
            // panelSeperator2
            // 
            this.panelSeperator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeperator2.Location = new System.Drawing.Point(0, 500);
            this.panelSeperator2.Name = "panelSeperator2";
            this.panelSeperator2.Size = new System.Drawing.Size(875, 5);
            this.panelSeperator2.TabIndex = 3;
            // 
            // panelWorOrders
            // 
            this.panelWorOrders.Controls.Add(this.panel4);
            this.panelWorOrders.Controls.Add(this.panel3);
            this.panelWorOrders.Controls.Add(this.panel7);
            this.panelWorOrders.Controls.Add(this.lblWorkOrder);
            this.panelWorOrders.Controls.Add(this.panelSeperator);
            this.panelWorOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWorOrders.Location = new System.Drawing.Point(0, 250);
            this.panelWorOrders.Name = "panelWorOrders";
            this.panelWorOrders.Size = new System.Drawing.Size(875, 250);
            this.panelWorOrders.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(437, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(437, 120);
            this.panel4.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 80);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(437, 40);
            this.panel8.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbWorkOrderNo);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(437, 40);
            this.panel6.TabIndex = 1;
            // 
            // tbWorkOrderNo
            // 
            this.tbWorkOrderNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbWorkOrderNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbWorkOrderNo.Location = new System.Drawing.Point(0, 0);
            this.tbWorkOrderNo.Name = "tbWorkOrderNo";
            this.tbWorkOrderNo.Size = new System.Drawing.Size(300, 39);
            this.tbWorkOrderNo.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(437, 40);
            this.panel5.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(437, 120);
            this.panel3.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(320, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 120);
            this.label1.TabIndex = 8;
            this.label1.Text = "İş Emri No : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnBitir);
            this.panel7.Controls.Add(this.btnWorkOrders);
            this.panel7.Controls.Add(this.btnBaslat);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 175);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(875, 75);
            this.panel7.TabIndex = 6;
            // 
            // btnBitir
            // 
            this.btnBitir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBitir.FlatAppearance.BorderSize = 0;
            this.btnBitir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBitir.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBitir.Location = new System.Drawing.Point(580, 0);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(290, 75);
            this.btnBitir.TabIndex = 5;
            this.btnBitir.Text = "Bitir";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // btnWorkOrders
            // 
            this.btnWorkOrders.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWorkOrders.FlatAppearance.BorderSize = 0;
            this.btnWorkOrders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWorkOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWorkOrders.Location = new System.Drawing.Point(290, 0);
            this.btnWorkOrders.Name = "btnWorkOrders";
            this.btnWorkOrders.Size = new System.Drawing.Size(290, 75);
            this.btnWorkOrders.TabIndex = 4;
            this.btnWorkOrders.Text = "İş Emirleri";
            this.btnWorkOrders.UseVisualStyleBackColor = true;
            this.btnWorkOrders.Click += new System.EventHandler(this.btnWorkOrders_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBaslat.FlatAppearance.BorderSize = 0;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Location = new System.Drawing.Point(0, 0);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(290, 75);
            this.btnBaslat.TabIndex = 3;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lblWorkOrder
            // 
            this.lblWorkOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWorkOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWorkOrder.Location = new System.Drawing.Point(0, 5);
            this.lblWorkOrder.Name = "lblWorkOrder";
            this.lblWorkOrder.Size = new System.Drawing.Size(875, 50);
            this.lblWorkOrder.TabIndex = 0;
            this.lblWorkOrder.Text = "WorkOrder";
            this.lblWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSeperator
            // 
            this.panelSeperator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeperator.Location = new System.Drawing.Point(0, 0);
            this.panelSeperator.Name = "panelSeperator";
            this.panelSeperator.Size = new System.Drawing.Size(875, 5);
            this.panelSeperator.TabIndex = 7;
            // 
            // panelDurum
            // 
            this.panelDurum.Controls.Add(this.pieDay);
            this.panelDurum.Controls.Add(this.lblTime);
            this.panelDurum.Controls.Add(this.lblKapali);
            this.panelDurum.Controls.Add(this.lblAcik);
            this.panelDurum.Controls.Add(this.panel2);
            this.panelDurum.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDurum.Location = new System.Drawing.Point(0, 50);
            this.panelDurum.Name = "panelDurum";
            this.panelDurum.Size = new System.Drawing.Size(875, 200);
            this.panelDurum.TabIndex = 0;
            // 
            // pieDay
            // 
            this.pieDay.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.pieDay.ChartAreas.Add(chartArea1);
            this.pieDay.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.pieDay.Legends.Add(legend1);
            this.pieDay.Location = new System.Drawing.Point(0, 0);
            this.pieDay.Name = "pieDay";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pieDay.Series.Add(series1);
            this.pieDay.Size = new System.Drawing.Size(300, 200);
            this.pieDay.TabIndex = 6;
            this.pieDay.Text = "chart1";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTime.Location = new System.Drawing.Point(350, 150);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 25);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "label4";
            // 
            // lblKapali
            // 
            this.lblKapali.AutoSize = true;
            this.lblKapali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblKapali.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapali.Location = new System.Drawing.Point(347, 86);
            this.lblKapali.Name = "lblKapali";
            this.lblKapali.Size = new System.Drawing.Size(67, 25);
            this.lblKapali.TabIndex = 4;
            this.lblKapali.Text = "Kapalı";
            // 
            // lblAcik
            // 
            this.lblAcik.AutoSize = true;
            this.lblAcik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblAcik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAcik.Location = new System.Drawing.Point(350, 25);
            this.lblAcik.Name = "lblAcik";
            this.lblAcik.Size = new System.Drawing.Size(50, 25);
            this.lblAcik.TabIndex = 3;
            this.lblAcik.Text = "Açık";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblDurum);
            this.panel2.Controls.Add(this.pbState);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(800, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 200);
            this.panel2.TabIndex = 2;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(0, 50);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(70, 25);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "Durum";
            // 
            // pbState
            // 
            this.pbState.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbState.Image = global::Dashboard.WinFormsUI.Properties.Resources.red;
            this.pbState.Location = new System.Drawing.Point(0, 0);
            this.pbState.Name = "pbState";
            this.pbState.Size = new System.Drawing.Size(75, 50);
            this.pbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbState.TabIndex = 1;
            this.pbState.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMakine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 50);
            this.panel1.TabIndex = 1;
            // 
            // lblMakine
            // 
            this.lblMakine.AutoSize = true;
            this.lblMakine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMakine.Location = new System.Drawing.Point(380, 16);
            this.lblMakine.Name = "lblMakine";
            this.lblMakine.Size = new System.Drawing.Size(86, 31);
            this.lblMakine.TabIndex = 0;
            this.lblMakine.Text = "label2";
            // 
            // timerDbCheck
            // 
            this.timerDbCheck.Tick += new System.EventHandler(this.timerDbCheck_Tick);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "AnaSayfa";
            this.Size = new System.Drawing.Size(875, 720);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.VisibleChanged += new System.EventHandler(this.AnaSayfa_VisibleChanged);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkOrderStates)).EndInit();
            this.panelWorOrders.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panelDurum.ResumeLayout(false);
            this.panelDurum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieDay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelDurum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbState;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblKapali;
        private System.Windows.Forms.Label lblAcik;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Timer timerDbCheck;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieDay;
        private System.Windows.Forms.Panel panelWorOrders;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Button btnWorkOrders;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Panel panelSeperator2;
        private System.Windows.Forms.Label lblWorkOrder;
        private System.Windows.Forms.Panel panelSeperator;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tbWorkOrderNo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMakine;
        private System.Windows.Forms.DataGridView dgvWorkOrderStates;
    }
}
