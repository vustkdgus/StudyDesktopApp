﻿
namespace IoTSensorMonApp
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.시뮬레이션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuBeginSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEndSimulation = new System.Windows.Forms.ToolStripMenuItem();
            this.LblConnectTime = new System.Windows.Forms.Label();
            this.TxtSensorNum = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LsbPhotoResistors = new System.Windows.Forms.ListBox();
            this.PrbPhotoResistor = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CboSerialPort = new System.Windows.Forms.ComboBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.ChtPhotoResistors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnViewAll = new System.Windows.Forms.Button();
            this.BtnZoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChtPhotoResistors)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.시뮬레이션ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuLoadFile,
            this.MnuSaveFile,
            this.toolStripMenuItem1,
            this.MnuExit});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // MnuLoadFile
            // 
            this.MnuLoadFile.Name = "MnuLoadFile";
            this.MnuLoadFile.Size = new System.Drawing.Size(180, 22);
            this.MnuLoadFile.Text = "읽어오기(&O)";
            // 
            // MnuSaveFile
            // 
            this.MnuSaveFile.Name = "MnuSaveFile";
            this.MnuSaveFile.Size = new System.Drawing.Size(180, 22);
            this.MnuSaveFile.Text = "저장하기(&S)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(180, 22);
            this.MnuExit.Text = "종료(&X)";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // 시뮬레이션ToolStripMenuItem
            // 
            this.시뮬레이션ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuBeginSimulation,
            this.MnuEndSimulation});
            this.시뮬레이션ToolStripMenuItem.Name = "시뮬레이션ToolStripMenuItem";
            this.시뮬레이션ToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.시뮬레이션ToolStripMenuItem.Text = "시뮬레이션(&S)";
            // 
            // MnuBeginSimulation
            // 
            this.MnuBeginSimulation.Name = "MnuBeginSimulation";
            this.MnuBeginSimulation.Size = new System.Drawing.Size(180, 22);
            this.MnuBeginSimulation.Text = "시작(&B)";
            this.MnuBeginSimulation.Click += new System.EventHandler(this.MnuBeginSimulation_Click);
            // 
            // MnuEndSimulation
            // 
            this.MnuEndSimulation.Name = "MnuEndSimulation";
            this.MnuEndSimulation.Size = new System.Drawing.Size(180, 22);
            this.MnuEndSimulation.Text = "끝(&E)";
            this.MnuEndSimulation.Click += new System.EventHandler(this.MnuEndSimulation_Click);
            // 
            // LblConnectTime
            // 
            this.LblConnectTime.AutoSize = true;
            this.LblConnectTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblConnectTime.Location = new System.Drawing.Point(23, 34);
            this.LblConnectTime.Name = "LblConnectTime";
            this.LblConnectTime.Size = new System.Drawing.Size(228, 15);
            this.LblConnectTime.TabIndex = 1;
            this.LblConnectTime.Text = "Connection Time : 2021-03-16 10:32:34";
            // 
            // TxtSensorNum
            // 
            this.TxtSensorNum.Location = new System.Drawing.Point(279, 34);
            this.TxtSensorNum.Name = "TxtSensorNum";
            this.TxtSensorNum.ReadOnly = true;
            this.TxtSensorNum.Size = new System.Drawing.Size(80, 21);
            this.TxtSensorNum.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PrbPhotoResistor);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.groupBox1.Location = new System.Drawing.Point(14, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PhotoResistor";
            // 
            // LsbPhotoResistors
            // 
            this.LsbPhotoResistors.FormattingEnabled = true;
            this.LsbPhotoResistors.ItemHeight = 12;
            this.LsbPhotoResistors.Location = new System.Drawing.Point(14, 158);
            this.LsbPhotoResistors.Name = "LsbPhotoResistors";
            this.LsbPhotoResistors.ScrollAlwaysVisible = true;
            this.LsbPhotoResistors.Size = new System.Drawing.Size(345, 100);
            this.LsbPhotoResistors.TabIndex = 3;
            // 
            // PrbPhotoResistor
            // 
            this.PrbPhotoResistor.Location = new System.Drawing.Point(6, 29);
            this.PrbPhotoResistor.Maximum = 1023;
            this.PrbPhotoResistor.Name = "PrbPhotoResistor";
            this.PrbPhotoResistor.Size = new System.Drawing.Size(330, 23);
            this.PrbPhotoResistor.TabIndex = 0;
            this.PrbPhotoResistor.Value = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnDisplay);
            this.groupBox2.Controls.Add(this.BtnDisconnect);
            this.groupBox2.Controls.Add(this.BtnConnect);
            this.groupBox2.Controls.Add(this.CboSerialPort);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.groupBox2.Location = new System.Drawing.Point(365, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 224);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port";
            // 
            // CboSerialPort
            // 
            this.CboSerialPort.FormattingEnabled = true;
            this.CboSerialPort.Location = new System.Drawing.Point(6, 29);
            this.CboSerialPort.Name = "CboSerialPort";
            this.CboSerialPort.Size = new System.Drawing.Size(89, 23);
            this.CboSerialPort.TabIndex = 4;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(6, 58);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(89, 35);
            this.BtnConnect.TabIndex = 5;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(6, 99);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(89, 35);
            this.BtnDisconnect.TabIndex = 6;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Font = new System.Drawing.Font("맑은 고딕", 14.25F);
            this.BtnDisplay.Location = new System.Drawing.Point(6, 140);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(89, 78);
            this.BtnDisplay.TabIndex = 7;
            this.BtnDisplay.Text = "COM3";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            // 
            // ChtPhotoResistors
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtPhotoResistors.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtPhotoResistors.Legends.Add(legend1);
            this.ChtPhotoResistors.Location = new System.Drawing.Point(12, 273);
            this.ChtPhotoResistors.Name = "ChtPhotoResistors";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChtPhotoResistors.Series.Add(series1);
            this.ChtPhotoResistors.Size = new System.Drawing.Size(460, 282);
            this.ChtPhotoResistors.TabIndex = 20;
            this.ChtPhotoResistors.Text = "chart1";
            // 
            // BtnViewAll
            // 
            this.BtnViewAll.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnViewAll.Location = new System.Drawing.Point(157, 567);
            this.BtnViewAll.Name = "BtnViewAll";
            this.BtnViewAll.Size = new System.Drawing.Size(75, 32);
            this.BtnViewAll.TabIndex = 8;
            this.BtnViewAll.Text = "View All";
            this.BtnViewAll.UseVisualStyleBackColor = true;
            this.BtnViewAll.Click += new System.EventHandler(this.BtnViewAll_Click);
            // 
            // BtnZoom
            // 
            this.BtnZoom.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.BtnZoom.Location = new System.Drawing.Point(259, 567);
            this.BtnZoom.Name = "BtnZoom";
            this.BtnZoom.Size = new System.Drawing.Size(75, 32);
            this.BtnZoom.TabIndex = 9;
            this.BtnZoom.Text = "Zoom";
            this.BtnZoom.UseVisualStyleBackColor = true;
            this.BtnZoom.Click += new System.EventHandler(this.BtnZoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "1023";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.BtnZoom);
            this.Controls.Add(this.BtnViewAll);
            this.Controls.Add(this.ChtPhotoResistors);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LsbPhotoResistors);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtSensorNum);
            this.Controls.Add(this.LblConnectTime);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IoT Photoresistor Monitoring";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChtPhotoResistors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuLoadFile;
        private System.Windows.Forms.ToolStripMenuItem MnuSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem 시뮬레이션ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuBeginSimulation;
        private System.Windows.Forms.ToolStripMenuItem MnuEndSimulation;
        private System.Windows.Forms.Label LblConnectTime;
        private System.Windows.Forms.TextBox TxtSensorNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar PrbPhotoResistor;
        private System.Windows.Forms.ListBox LsbPhotoResistors;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.ComboBox CboSerialPort;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtPhotoResistors;
        private System.Windows.Forms.Button BtnViewAll;
        private System.Windows.Forms.Button BtnZoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

