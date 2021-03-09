using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlagWinApp
{
    public partial class FrmMain : Form
    {
        private bool isHello = false; // flag 상태를 저장.
        public FrmMain()
        {
            InitializeComponent();

            isHello = true; // 아침임. 초기화
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblGreeding.Text = string.Empty;
        }

        private void BtnGreeding_Click(object sender, EventArgs e)
        {
            if (isHello == true)
            {
                LblGreeding.Text = "Good Morning!";
                isHello = false;
                BtnGreeding.Text = "저녁인사";
            }
            else if (isHello == false)
            {
                LblGreeding.Text = "Good Bye~";
                isHello = true;
                BtnGreeding.Text = "아침인사";
            }
        }
    }
}
