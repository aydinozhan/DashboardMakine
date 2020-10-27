namespace Dashboard.WinFormsUI.UserControls
{
    partial class AnaSayfaWarning
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pbState = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblMakine = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDurum = new System.Windows.Forms.Label();
            this.pieDay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblKapali = new System.Windows.Forms.Label();
            this.lblAcik = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSeperator2 = new System.Windows.Forms.Panel();
            this.panelDurum = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStopCode = new System.Windows.Forms.TextBox();
            this.rtbExp = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieDay)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelDurum.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
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
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick_1);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblMakine);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 50);
            this.panel1.TabIndex = 1;
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
            // pieDay
            // 
            this.pieDay.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.pieDay.ChartAreas.Add(chartArea3);
            this.pieDay.Dock = System.Windows.Forms.DockStyle.Left;
            legend3.Name = "Legend1";
            this.pieDay.Legends.Add(legend3);
            this.pieDay.Location = new System.Drawing.Point(0, 0);
            this.pieDay.Name = "pieDay";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pieDay.Series.Add(series3);
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
            // panelSeperator2
            // 
            this.panelSeperator2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeperator2.Location = new System.Drawing.Point(0, 250);
            this.panelSeperator2.Name = "panelSeperator2";
            this.panelSeperator2.Size = new System.Drawing.Size(875, 5);
            this.panelSeperator2.TabIndex = 3;
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
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.panelSeperator2);
            this.panelMain.Controls.Add(this.panelDurum);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(875, 720);
            this.panelMain.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.label3);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.tbStopCode);
            this.panelBottom.Controls.Add(this.rtbExp);
            this.panelBottom.Controls.Add(this.btnKaydet);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.Location = new System.Drawing.Point(0, 255);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(875, 465);
            this.panelBottom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gerekliyse Açıklama : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(261, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Duruş Kodu : ";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(875, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Duruş Nedeni Giriniz !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStopCode
            // 
            this.tbStopCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbStopCode.Location = new System.Drawing.Point(386, 103);
            this.tbStopCode.Name = "tbStopCode";
            this.tbStopCode.Size = new System.Drawing.Size(100, 30);
            this.tbStopCode.TabIndex = 2;
            // 
            // rtbExp
            // 
            this.rtbExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rtbExp.Location = new System.Drawing.Point(202, 148);
            this.rtbExp.Name = "rtbExp";
            this.rtbExp.Size = new System.Drawing.Size(452, 127);
            this.rtbExp.TabIndex = 1;
            this.rtbExp.Text = "";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(366, 296);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(134, 78);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // AnaSayfaWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "AnaSayfaWarning";
            this.Size = new System.Drawing.Size(875, 720);
            this.Load += new System.EventHandler(this.AnaSayfaWarning_Load);
            this.VisibleChanged += new System.EventHandler(this.AnaSayfaWarning_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbState)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieDay)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDurum.ResumeLayout(false);
            this.panelDurum.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbState;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblMakine;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieDay;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblKapali;
        private System.Windows.Forms.Label lblAcik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSeperator2;
        private System.Windows.Forms.Panel panelDurum;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStopCode;
        private System.Windows.Forms.RichTextBox rtbExp;
        private System.Windows.Forms.Button btnKaydet;
    }
}
