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

namespace Winform.QuanLy
{
    public partial class Manager_Tang : Form
    {
        public Manager_Tang()
        {
            InitializeComponent();
        }
        bool edit = true;
        private void Manager_Tang_Load(object sender, EventArgs e)
        {
            ShowTangAll();
            ShowDetail();
        }

        #region show detail tâng
        private void ShowDetail()
        {
            if (dvgTang.CurrentRow != null)
            {
                var row = dvgTang.CurrentRow;
                txtId.Text = row.Cells[0].Value.ToString();
                txtTang.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value.ToString()== "Hoạt Động")
                {
                    ckStatus.Checked = true;
                }
                else
                {
                    ckStatus.Checked = false;
                }
                
            }
        }
        #endregion


        #region Lấy ra tất cả các tầng hiện tại
        private void ShowTangAll()
        {
            SqlDataAdapter sql = new SqlDataAdapter("GetTangAll", SQLConnectionDatabase.Connection);
            sql.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            sql.Fill(ds,"Tang");
            dvgTang.DataSource = ds.Tables["Tang"];

            
        }
        #endregion

        #region sự kiện click lấy ra tầng được click
        private void dvgTang_Click(object sender, EventArgs e)
        {
            ShowDetail();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit = false;
            txtId.ReadOnly = true;
            txtTang.Text = "";
            txtTang.Focus();
            //galleryitem
           
        }


        #region thực hiện thêm mới hoặc cập nhập
        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                // thêm mới
                SqlCommand sql = SQLConnectionDatabase.Connection.CreateCommand();
                sql.CommandText = "AddTang";
                sql.CommandType = CommandType.StoredProcedure;

                // gán giá trị cho tham số
                    sql.Parameters.AddWithValue("name", txtTang.Text);
                if (ckStatus.Checked)
                {
                    sql.Parameters.AddWithValue("status", 1);
                }
                else
                {
                    sql.Parameters.AddWithValue("status", 0);
                }
                    
                // thực thi
                int row = sql.ExecuteNonQuery();
                
                if(row > 0)
                {
                    ShowTangAll();
                    ShowDetail();
                    edit = true;
                }
            }
            else
            {
                // cập Nhập
                SqlCommand sql = SQLConnectionDatabase.Connection.CreateCommand();
                sql.CommandText = "UpdateTang";
                sql.CommandType = CommandType.StoredProcedure;

                // gán giá trị cho tham số
                sql.Parameters.AddWithValue("name", txtTang.Text);
                sql.Parameters.AddWithValue("status", ckStatus.Checked);
                sql.Parameters.AddWithValue("id", txtId.Text);
                // thực thi
                int row = sql.ExecuteNonQuery();

                ShowTangAll();
                ShowDetail();
            }
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
                cmd.CommandText = "DeleteTang";
                cmd.CommandType = CommandType.StoredProcedure;
                // gán giá trị
                cmd.Parameters.AddWithValue("id", txtId.Text);
                // thực thi
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDetail();
                ShowTangAll();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            this.Clear();
        }


        public void Clear()
        {
            txtTang.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
            cmd.CommandText = "GetTangByName";
            cmd.CommandType = CommandType.StoredProcedure;
            // gán giá trị
            cmd.Parameters.AddWithValue("@name", txtSearch.Text);

            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            dvgTang.DataSource = dt;
        }

      


        private bool CheckNameTang()
        {
            bool check = false;

            SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
            cmd.CommandText = "CheckNameTang";
            cmd.CommandType = CommandType.StoredProcedure;
            // gán giá trị
            cmd.Parameters.AddWithValue("@name", txtTang.Text);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                check = true;

            }
            return check;
        }
    }
}
