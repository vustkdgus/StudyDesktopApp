﻿
namespace BookRentalShopApp
{
    partial class FrmMember
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.TxtNames = new MetroFramework.Controls.MetroTextBox();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TxtAddr = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.CboLevels = new System.Windows.Forms.ComboBox();
            this.TxtMobile = new MetroFramework.Controls.MetroTextBox();
            this.TxtEmail = new MetroFramework.Controls.MetroTextBox();
            this.TxtUserId = new MetroFramework.Controls.MetroTextBox();
            this.TxtPasswords = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TxtPasswords);
            this.groupBox1.Controls.Add(this.TxtUserId);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtMobile);
            this.groupBox1.Controls.Add(this.CboLevels);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.TxtAddr);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.TxtNames);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.TxtIdx);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(433, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 364);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(252, 320);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 28);
            this.BtnSave.TabIndex = 12;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(169, 320);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 28);
            this.BtnNew.TabIndex = 11;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(88, 320);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 28);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtNames
            // 
            // 
            // 
            // 
            this.TxtNames.CustomButton.Image = null;
            this.TxtNames.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtNames.CustomButton.Name = "";
            this.TxtNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNames.CustomButton.TabIndex = 1;
            this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNames.CustomButton.UseSelectable = true;
            this.TxtNames.CustomButton.Visible = false;
            this.TxtNames.Lines = new string[0];
            this.TxtNames.Location = new System.Drawing.Point(108, 56);
            this.TxtNames.MaxLength = 32767;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.PasswordChar = '\0';
            this.TxtNames.PromptText = "이름";
            this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNames.SelectedText = "";
            this.TxtNames.SelectionLength = 0;
            this.TxtNames.SelectionStart = 0;
            this.TxtNames.ShortcutsEnabled = true;
            this.TxtNames.Size = new System.Drawing.Size(219, 23);
            this.TxtNames.TabIndex = 3;
            this.TxtNames.UseSelectable = true;
            this.TxtNames.WaterMark = "이름";
            this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNames.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(108, 27);
            this.TxtIdx.MaxLength = 32767;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.PromptText = "순번";
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(219, 23);
            this.TxtIdx.TabIndex = 2;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMark = "순번";
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(45, 56);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "이름 :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(45, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(44, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "순번 :";
            // 
            // DgvData
            // 
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(24, 64);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(403, 363);
            this.DgvData.TabIndex = 1;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(45, 84);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "레벨 :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(45, 114);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "주소 :";
            // 
            // TxtAddr
            // 
            // 
            // 
            // 
            this.TxtAddr.CustomButton.Image = null;
            this.TxtAddr.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtAddr.CustomButton.Name = "";
            this.TxtAddr.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtAddr.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddr.CustomButton.TabIndex = 1;
            this.TxtAddr.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddr.CustomButton.UseSelectable = true;
            this.TxtAddr.CustomButton.Visible = false;
            this.TxtAddr.Lines = new string[0];
            this.TxtAddr.Location = new System.Drawing.Point(108, 114);
            this.TxtAddr.MaxLength = 32767;
            this.TxtAddr.Name = "TxtAddr";
            this.TxtAddr.PasswordChar = '\0';
            this.TxtAddr.PromptText = "주소";
            this.TxtAddr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddr.SelectedText = "";
            this.TxtAddr.SelectionLength = 0;
            this.TxtAddr.SelectionStart = 0;
            this.TxtAddr.ShortcutsEnabled = true;
            this.TxtAddr.Size = new System.Drawing.Size(219, 23);
            this.TxtAddr.TabIndex = 5;
            this.TxtAddr.UseSelectable = true;
            this.TxtAddr.WaterMark = "주소";
            this.TxtAddr.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddr.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(31, 146);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(58, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "핸드폰 :";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(31, 175);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(58, 19);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "이메일 :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(31, 205);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(58, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "아이디 :";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(17, 235);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(72, 19);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "패스워드 :";
            // 
            // CboLevels
            // 
            this.CboLevels.FormattingEnabled = true;
            this.CboLevels.ItemHeight = 12;
            this.CboLevels.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "S"});
            this.CboLevels.Location = new System.Drawing.Point(108, 86);
            this.CboLevels.Name = "CboLevels";
            this.CboLevels.Size = new System.Drawing.Size(91, 20);
            this.CboLevels.TabIndex = 4;
            this.CboLevels.Text = "레벨";
            // 
            // TxtMobile
            // 
            // 
            // 
            // 
            this.TxtMobile.CustomButton.Image = null;
            this.TxtMobile.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtMobile.CustomButton.Name = "";
            this.TxtMobile.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMobile.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMobile.CustomButton.TabIndex = 1;
            this.TxtMobile.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMobile.CustomButton.UseSelectable = true;
            this.TxtMobile.CustomButton.Visible = false;
            this.TxtMobile.Lines = new string[0];
            this.TxtMobile.Location = new System.Drawing.Point(108, 146);
            this.TxtMobile.MaxLength = 32767;
            this.TxtMobile.Name = "TxtMobile";
            this.TxtMobile.PasswordChar = '\0';
            this.TxtMobile.PromptText = "핸드폰";
            this.TxtMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMobile.SelectedText = "";
            this.TxtMobile.SelectionLength = 0;
            this.TxtMobile.SelectionStart = 0;
            this.TxtMobile.ShortcutsEnabled = true;
            this.TxtMobile.Size = new System.Drawing.Size(219, 23);
            this.TxtMobile.TabIndex = 6;
            this.TxtMobile.UseSelectable = true;
            this.TxtMobile.WaterMark = "핸드폰";
            this.TxtMobile.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMobile.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtEmail
            // 
            // 
            // 
            // 
            this.TxtEmail.CustomButton.Image = null;
            this.TxtEmail.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtEmail.CustomButton.Name = "";
            this.TxtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtEmail.CustomButton.TabIndex = 1;
            this.TxtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtEmail.CustomButton.UseSelectable = true;
            this.TxtEmail.CustomButton.Visible = false;
            this.TxtEmail.Lines = new string[0];
            this.TxtEmail.Location = new System.Drawing.Point(108, 175);
            this.TxtEmail.MaxLength = 32767;
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PasswordChar = '\0';
            this.TxtEmail.PromptText = "이메일";
            this.TxtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.SelectionLength = 0;
            this.TxtEmail.SelectionStart = 0;
            this.TxtEmail.ShortcutsEnabled = true;
            this.TxtEmail.Size = new System.Drawing.Size(219, 23);
            this.TxtEmail.TabIndex = 7;
            this.TxtEmail.UseSelectable = true;
            this.TxtEmail.WaterMark = "이메일";
            this.TxtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtEmail.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtUserId
            // 
            // 
            // 
            // 
            this.TxtUserId.CustomButton.Image = null;
            this.TxtUserId.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtUserId.CustomButton.Name = "";
            this.TxtUserId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtUserId.CustomButton.TabIndex = 1;
            this.TxtUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtUserId.CustomButton.UseSelectable = true;
            this.TxtUserId.CustomButton.Visible = false;
            this.TxtUserId.Lines = new string[0];
            this.TxtUserId.Location = new System.Drawing.Point(108, 205);
            this.TxtUserId.MaxLength = 32767;
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.PasswordChar = '\0';
            this.TxtUserId.PromptText = "아이디";
            this.TxtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtUserId.SelectedText = "";
            this.TxtUserId.SelectionLength = 0;
            this.TxtUserId.SelectionStart = 0;
            this.TxtUserId.ShortcutsEnabled = true;
            this.TxtUserId.Size = new System.Drawing.Size(219, 23);
            this.TxtUserId.TabIndex = 8;
            this.TxtUserId.UseSelectable = true;
            this.TxtUserId.WaterMark = "아이디";
            this.TxtUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtUserId.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPasswords
            // 
            // 
            // 
            // 
            this.TxtPasswords.CustomButton.Image = null;
            this.TxtPasswords.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.TxtPasswords.CustomButton.Name = "";
            this.TxtPasswords.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPasswords.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPasswords.CustomButton.TabIndex = 1;
            this.TxtPasswords.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPasswords.CustomButton.UseSelectable = true;
            this.TxtPasswords.CustomButton.Visible = false;
            this.TxtPasswords.Lines = new string[0];
            this.TxtPasswords.Location = new System.Drawing.Point(108, 235);
            this.TxtPasswords.MaxLength = 32767;
            this.TxtPasswords.Name = "TxtPasswords";
            this.TxtPasswords.PasswordChar = '●';
            this.TxtPasswords.PromptText = "패스워드";
            this.TxtPasswords.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPasswords.SelectedText = "";
            this.TxtPasswords.SelectionLength = 0;
            this.TxtPasswords.SelectionStart = 0;
            this.TxtPasswords.ShortcutsEnabled = true;
            this.TxtPasswords.Size = new System.Drawing.Size(219, 23);
            this.TxtPasswords.TabIndex = 9;
            this.TxtPasswords.UseSelectable = true;
            this.TxtPasswords.WaterMark = "패스워드";
            this.TxtPasswords.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPasswords.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMember";
            this.Text = "회원 관리";
            this.Load += new System.EventHandler(this.FrmDivCode_Load);
            this.Resize += new System.EventHandler(this.FrmDivCode_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroTextBox TxtNames;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView DgvData;
        private MetroFramework.Controls.MetroTextBox TxtAddr;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ComboBox CboLevels;
        private MetroFramework.Controls.MetroTextBox TxtPasswords;
        private MetroFramework.Controls.MetroTextBox TxtUserId;
        private MetroFramework.Controls.MetroTextBox TxtEmail;
        private MetroFramework.Controls.MetroTextBox TxtMobile;
    }
}