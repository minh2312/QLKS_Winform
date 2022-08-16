using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Winform.Connect;
using Winform.Shared;

namespace Winform.QuanLy
{
    public partial class QuanLyLoaiPhong : Form
    {
        public QuanLyLoaiPhong()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        bool edit = true;
        private void QuanLyLoaiPhong_Load(object sender, EventArgs e)
        {
            ShowAllLoaiPhong();
            ShowDetail();
        }

        private void ShowDetail()
        {
            if (dvgLoaiPhong.CurrentRow!=null)
            {
                var row = dvgLoaiPhong.CurrentRow;
                txtId.Text = row.Cells[0].Value.ToString();
                txtLoaiPhong.Text = row.Cells[1].Value.ToString();
                numPrice.Value = decimal.Parse(row.Cells[2].Value.ToString());
                if (row.Cells[3].Value.ToString() == "1")
                {
                    ckStatus.Checked = true;
                }
                else
                {
                    ckStatus.Checked = false;
                }
                
            }
        }

        private void ShowAllLoaiPhong()
        {
            //SqlDataAdapter sql = new SqlDataAdapter("GetAllLoaiPhong", SQLConnectionDatabase.Connection);
            //sql.SelectCommand.CommandType = CommandType.StoredProcedure;
            //DataSet ds = new DataSet();
            //sql.Fill(ds, "LoaiPhong");
            DataSet ds = new DataSet();
            GetData data = new GetData("GetAllLoaiPhong", "LoaiPhong");
            data.GetListData(ds);
            dvgLoaiPhong.DataSource = ds.Tables["LoaiPhong"];

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit = false;
            txtId.ReadOnly = true;
            txtLoaiPhong.Text = "";
            numPrice.Value = 0;
            txtLoaiPhong.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                // theem moi
                SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
                cmd.CommandText = "InsertLoaiPhong";
                cmd.CommandType = CommandType.StoredProcedure;

                // gán giá trị
                cmd.Parameters.AddWithValue("@name", txtLoaiPhong.Text);
                cmd.Parameters.AddWithValue("@price", numPrice.Value);
                cmd.Parameters.AddWithValue("@status", ckStatus.Checked);

                // thực thi
                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    edit = true;
                    ShowAllLoaiPhong();
                    ShowDetail();
                }
                
            }
            else
            {
                // cap nhap
                SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
                cmd.CommandText = "UpdateLoaiPhong";
                cmd.CommandType = CommandType.StoredProcedure;

                // gán giá trị
                cmd.Parameters.AddWithValue("@name", txtLoaiPhong.Text);
                cmd.Parameters.AddWithValue("@price", numPrice.Value);
                cmd.Parameters.AddWithValue("@status", ckStatus.Checked);
                cmd.Parameters.AddWithValue("@id", txtId.Text);

                // thực thi
                int row = cmd.ExecuteNonQuery();
                ShowAllLoaiPhong();
                ShowDetail();
            }
        }

        private void dvgLoaiPhong_Click(object sender, EventArgs e)
        {
            ShowDetail();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
                cmd.CommandText = "DeleteLoaiPhong";
                cmd.CommandType = CommandType.StoredProcedure;
                // gán giá trị
                cmd.Parameters.AddWithValue("id", txtId.Text);
                // thực thi
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Đã xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowDetail();
                ShowAllLoaiPhong();
            }
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            
            if (!edit)
            {
                this.Clear();
            }
            else
            {
                ShowDetail();
            }
        }

        public void Clear()
        {
            txtLoaiPhong.Text = "";
            numPrice.Value = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
            cmd.CommandText = "GetLoaiPhongByName";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", txtSearch.Text);
            SqlDataAdapter sql = new SqlDataAdapter(cmd);


        }
    }
}
