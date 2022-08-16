using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Connect;

namespace Winform
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn Có Chắc Chắn Muốn Thoát", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        string id = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string pass = txtPassword.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Tên Tài Khoản");
            }
            else if (pass.Trim() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu");
            }
            else
            {
                if (checkLogin())
                {
                    FrmMain frmMain = new FrmMain(id);
                    ChangePass cs = new ChangePass();
                    frmMain.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai Email Hoặc Sai Mật Khẩu");
                }
            }


        }


        //minhaz23122002@gmail.com
        // check login 
        bool checkLogin()
        {
            string email = txtEmail.Text;
            string pass = txtPassword.Text;

            bool check = false;
            SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
            cmd.CommandText = "getAccountByEmail";
            cmd.CommandType = CommandType.StoredProcedure;
            //gán giá trị cho tham số
            cmd.Parameters.AddWithValue("email", txtEmail.Text);
            //cmd.Parameters.Add(@email, SqlDbType.VarChar,150).Value = txtEmail.Text;
            //thực thi
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    if (dr.GetString(2) == email && dr.GetString(3) == pass)
                    {
                        this.id = dr.GetInt32(0).ToString();
                        check = true;
                    }
                }
            }

            return check;
        }


        private void checkPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPass.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePass cp = new ChangePass();
            cp.Show();
            this.Hide();
            
        }
    }
}
