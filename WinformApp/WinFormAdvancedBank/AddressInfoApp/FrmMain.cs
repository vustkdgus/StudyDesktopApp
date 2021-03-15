﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressInfoApp
{
    public partial class FrmMain : Form
    {
        string connString = "Data Source=127.0.0.1;Initial Catalog = PMS;Persist Security Info = True; " +
                            "User ID = sa; Password = mssql_p@ssw0rd!";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("수정하려는 데이터를 선택하십시오.");
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    string query = $" UPDATE Address " +
                                   $" Set " +
                                   $" FullName = '{TxtFullName.Text}', " +
                                   $" Mobile = '{TxtMobile.Text.Replace("-","")}', " +
                                   $" Addr = '{TxtAddress.Text}', " +
                                   $" ModId = 'admin', " +
                                   $" ModDate = GETDATE() " +
                                   $" WHERE Idx = {result} ";


                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("수정 성공!");
                    }
                    else
                    {
                        MessageBox.Show("수정 실패");
                    }
                }

                ClearInput();
                RefreshData();
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result > 0)
            {
                MessageBox.Show("초기화를 하십시오.");
                return;
            }

            if (string.IsNullOrEmpty(TxtFullName.Text) || string.IsNullOrEmpty(TxtMobile.Text))
            {
                MessageBox.Show("값을 입력하세요.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = $"INSERT INTO dbo.Address (FullName, Mobile, Addr, RegId, RegDate) " +
                               $"VALUES ('{TxtFullName.Text}', '{TxtMobile.Text.Replace("-","")}', '{TxtAddress.Text}', 'admin', GETDATE() ); ";

                SqlCommand cmd = new SqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("입력 성공!");
                }
                else
                {
                    MessageBox.Show("입력 실패!");
                }
            }
            ClearInput();
            RefreshData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int.TryParse(TxtIdx.Text, out int result);
            if (result == 0)
            {
                MessageBox.Show("삭제하려는 데이터를 선택하십시오.");
                return;
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    if (conn.State == ConnectionState.Closed)
                        conn.Open();

                    string query = $"DELETE FROM Address WHERE idx = {result} ";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("삭제 성공!");
                    }
                    else
                    {
                        MessageBox.Show("삭제 실패");
                    }

                }

                ClearInput();
                RefreshData();
            }
        }

        private void TxtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 엔터 
            {
                TxtMobile.Focus();
            }
        }

        private void TxtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 엔터 
            {
                TxtAddress.Focus();
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // SSMS 테이블 스크립팅 메뉴활용
                string query = "SELECT  Idx " +
                               " , FullName " +
                               " , Mobile " +
                               " , Addr " +
                               " FROM dbo.Address ";
                // SqlCommand, SqlDataReader or Object 사용방법 1
                // SqlDataAdapter, DataSet

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);

                DgvAddress.DataSource = ds.Tables[0];
                
                /*SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();*/
            }
        }

        private void ClearInput()
        {
            TxtIdx.Text = TxtFullName.Text = TxtMobile.Text = TxtAddress.Text = "";
        }

        private void DgvAddress_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selData = DgvAddress.Rows[e.RowIndex].Cells;

            TxtIdx.Text = selData[0].Value.ToString();
            TxtFullName.Text = selData[1].Value.ToString();
            TxtMobile.Text = selData[2].Value.ToString();
            TxtAddress.Text = selData[3].Value.ToString();
        }
    }
}
