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
    public partial class QuanLyRoom : Form
    {
        public QuanLyRoom()
        {
            InitializeComponent();
        }

        bool edit = true;
        private void QuanLyRoom_Load(object sender, EventArgs e)
        {
            ShowAllTang();
            ShowAllLoaiPhong();
            GetAllData();
            ShowDetailRoom();
        }

        private void ShowDetailRoom()
        {
            
            if (dvgRoom.CurrentRow != null)
            {
                var row = dvgRoom.CurrentRow;
                txtId.Text = row.Cells[0].Value.ToString();
                txtPhong.Text = row.Cells[1].Value.ToString();
                numNguoiToiDa.Value = decimal.Parse(row.Cells[2].Value.ToString());
                cboTang.SelectedValue = row.Cells[4].Value.ToString();
                cboLoaiPhong.SelectedValue = row.Cells[6].Value.ToString();
                //ckStatus.Checked = bool.Parse(row.Cells[3].Value.ToString());
                if (row.Cells[3].Value.ToString() == "Còn Phòng")
                {
                    ckStatus.Checked = true;
                }
                else
                {
                    ckStatus.Checked = false;
                }

            }
        }

        private void GetAllData()
        {
            DataSet ds = new DataSet();
            GetData data = new GetData("GetAllPhong", "Room");
            data.GetListData(ds);
            dvgRoom.DataSource = ds.Tables["Room"];
            
        }

        private void ShowAllTang()
        {
            SqlDataAdapter sql = new SqlDataAdapter("GetTangAll", SQLConnectionDatabase.Connection);
            sql.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            sql.Fill(ds, "Tang");
            cboTang.DataSource = ds.Tables["Tang"];
            cboTang.DisplayMember = "Name";
            cboTang.ValueMember = "Id";
        }

        private void ShowAllLoaiPhong()
        {
            DataSet ds = new DataSet();
            GetData data = new GetData("GetAllLoaiPhong", "LoaiPhong");
            data.GetListData(ds);
            cboLoaiPhong.DataSource = ds.Tables["LoaiPhong"];
            cboLoaiPhong.DisplayMember = "Name";
            cboLoaiPhong.ValueMember = "Id";
        }

        private void dvgRoom_Click(object sender, EventArgs e)
        {
            ShowDetailRoom();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            edit = false;
            txtId.ReadOnly = true;
            txtPhong.Text = "";
            numNguoiToiDa.Value = 0;
            txtPhong.Focus();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                // thêm mới
                // theem moi
                SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
                cmd.CommandText = "InsertRoom";
                cmd.CommandType = CommandType.StoredProcedure;
                ;
                // gán giá trị
                cmd.Parameters.AddWithValue("@name",txtPhong.Text );
                cmd.Parameters.AddWithValue("@soNguoi",numNguoiToiDa.Value);
                cmd.Parameters.AddWithValue("@status", ckStatus.Checked);
                cmd.Parameters.AddWithValue("@idTang", cboTang.SelectedValue);
                cmd.Parameters.AddWithValue("@idLoaiPhong", cboLoaiPhong.SelectedValue);

                // thực thi
                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    ShowAllTang();
                    ShowAllLoaiPhong();
                    GetAllData();
                    ShowDetailRoom();
                    edit = true;
                }

                
            }
            else
            {
                // cập nhập
                SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
                cmd.CommandText = "UpdateRoom";
                cmd.CommandType = CommandType.StoredProcedure;

                // gán giá trị
                cmd.Parameters.AddWithValue("@name", txtPhong.Text);
                cmd.Parameters.AddWithValue("@soNguoi", numNguoiToiDa.Value);
                cmd.Parameters.AddWithValue("@status", ckStatus.Checked);
                cmd.Parameters.AddWithValue("@idTang", cboTang.SelectedValue);
                cmd.Parameters.AddWithValue("@idLoaiPhong", cboLoaiPhong.SelectedValue);
                cmd.Parameters.AddWithValue("@idRoom", txtId.Text);

                // thực thi
                int row = cmd.ExecuteNonQuery();

                ShowAllTang();
                ShowAllLoaiPhong();
                GetAllData();
                ShowDetailRoom();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
            cmd.CommandText = "DeleteRoom";
            cmd.CommandType = CommandType.StoredProcedure;

            // gán giá trị
            cmd.Parameters.AddWithValue("@idRoom", txtId.Text);

            // thực thi
            int row = cmd.ExecuteNonQuery();

            ShowAllTang();
            ShowAllLoaiPhong();
            GetAllData();
            ShowDetailRoom();
        }
        

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void Clear()
        {
            txtPhong.Text = "";
        }
       

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //ad = new SqlDataAdapter(chuoi, SQLConnectionDatabase.StringConnection);
            //dt = new DataTable();
            //bd = new SqlCommandBuilder(ad);
            //ad.Fill(dt);
            //db2.DataSource = dt;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chăn muốn thoát không ? ", "Thông báo ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
            cmd.CommandText = "GetRoomByName";
            cmd.CommandType = CommandType.StoredProcedure;
            // gán giá trị
            cmd.Parameters.AddWithValue("@name", txtSearch.Text);

            SqlDataAdapter sql = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sql.Fill(dt);
            dvgRoom.DataSource = dt;
        }
    }
}
