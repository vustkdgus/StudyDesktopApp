﻿
namespace FlagWinApp
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
            this.LblGreeding = new System.Windows.Forms.Label();
            this.BtnGreeding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblGreeding
            // 
            this.LblGreeding.AutoSize = true;
            this.LblGreeding.Location = new System.Drawing.Point(32, 59);
            this.LblGreeding.Name = "LblGreeding";
            this.LblGreeding.Size = new System.Drawing.Size(73, 12);
            this.LblGreeding.TabIndex = 0;
            this.LblGreeding.Text = "LblGreeding";
            // 
            // BtnGreeding
            // 
            this.BtnGreeding.Location = new System.Drawing.Point(66, 131);
            this.BtnGreeding.Name = "BtnGreeding";
            this.BtnGreeding.Size = new System.Drawing.Size(101, 42);
            this.BtnGreeding.TabIndex = 1;
            this.BtnGreeding.Text = "인사하기";
            this.BtnGreeding.UseVisualStyleBackColor = true;
            this.BtnGreeding.Click += new System.EventHandler(this.BtnGreeding_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 191);
            this.Controls.Add(this.BtnGreeding);
            this.Controls.Add(this.LblGreeding);
            this.Name = "FrmMain";
            this.Text = "Greeding App";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGreeding;
        private System.Windows.Forms.Button BtnGreeding;
    }
}

