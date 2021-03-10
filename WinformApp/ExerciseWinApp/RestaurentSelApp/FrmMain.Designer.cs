
namespace RestaurentSelApp
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
            this.LblFavorite = new System.Windows.Forms.Label();
            this.CboRestaurent = new System.Windows.Forms.ComboBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFavorite
            // 
            this.LblFavorite.AutoSize = true;
            this.LblFavorite.Location = new System.Drawing.Point(31, 26);
            this.LblFavorite.Name = "LblFavorite";
            this.LblFavorite.Size = new System.Drawing.Size(121, 12);
            this.LblFavorite.TabIndex = 0;
            this.LblFavorite.Text = "좋아하는 식당 리스트";
            // 
            // CboRestaurent
            // 
            this.CboRestaurent.FormattingEnabled = true;
            this.CboRestaurent.Location = new System.Drawing.Point(33, 56);
            this.CboRestaurent.Name = "CboRestaurent";
            this.CboRestaurent.Size = new System.Drawing.Size(166, 20);
            this.CboRestaurent.TabIndex = 1;
            this.CboRestaurent.SelectedIndexChanged += new System.EventHandler(this.CboRestaurent_SelectedIndexChanged);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(219, 53);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "추가";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(219, 94);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 3;
            this.BtnRemove.Text = "삭제";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Location = new System.Drawing.Point(31, 132);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(117, 12);
            this.LblResult.TabIndex = 4;
            this.LblResult.Text = "이번 주 모임장소는 :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 182);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.CboRestaurent);
            this.Controls.Add(this.LblFavorite);
            this.Name = "FrmMain";
            this.Text = "좋아하는 레스토랑";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFavorite;
        private System.Windows.Forms.ComboBox CboRestaurent;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Label LblResult;
    }
}

