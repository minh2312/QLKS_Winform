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
using Winform.Shared;

namespace Winform.QLDatPhong
{
    public partial class DatPhong : Form
    {
        public DatPhong()
        {
            InitializeComponent();
        }

        private void DatPhong_Load(object sender, EventArgs e)
        {
            ShowAllCustomer();
            ShowAllPhong();
            ShowDetailRoom();
            SelectValueRoom();
            ShowAllDatPhong();
        }

        private void ShowAllDatPhong()
        {
            DataSet ds = new DataSet();
            GetData data = new GetData("GetAllDatPhong", "DatPhong");
            data.GetListData(ds);
            dvgDatPhong.DataSource = ds.Tables["DatPhong"];
        }

        private void ShowAllCustomer()
        {
            DataSet ds = new DataSet();
            GetData data = new GetData("GetAllCustomer", "Customer");
            data.GetListData(ds);
            dvgCustomer.DataSource = ds.Tables["Customer"];
        }

        private void ShowAllPhong()
        {
            DataSet ds = new DataSet();
            GetData data = new GetData("GetAllPhong", "Room");
            data.GetListData(ds);
            dvgRoom.DataSource = ds.Tables["Room"];
            
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
            cmd.CommandText = "InsertCustomer";
            cmd.CommandType = CommandType.StoredProcedure;
            // gán giá trị
            cmd.Parameters.AddWithValue("@id", txtMaKH.Text);
            cmd.Parameters.AddWithValue("@fullName", txtFullName.Text);
            cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtSDT.Text);
            cmd.Parameters.AddWithValue("@address", txtAddress.Text);
            if (rdNam.Checked)
            {
                cmd.Parameters.AddWithValue("@gender", 1);
            }
            else if (rdNu.Checked)
            {
                cmd.Parameters.AddWithValue("@gender", 0);
            }
            else
            {
                cmd.Parameters.AddWithValue("@gender", 3);
            }
            cmd.Parameters.AddWithValue("@birthday", dateBirthday.Value);

            // thực thi
            int row = cmd.ExecuteNonQuery();

            if (row > 0)
            {
                SqlCommand cmd1 = SQLConnectionDatabase.Connection.CreateCommand();
                cmd1.CommandText = "InsertDatPhong";
                cmd1.CommandType = CommandType.StoredProcedure;
                // gán giá trị
                cmd1.Parameters.AddWithValue("@idCustomer", txtMaKH.Text);
                cmd1.Parameters.AddWithValue("@roomId", txtIdPhong.Text);
                cmd1.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd1.Parameters.AddWithValue("@startDate", dateStart.Value);
                cmd1.Parameters.AddWithValue("@endDate", dateEnd.Value);
                cmd1.Parameters.AddWithValue("@status", 1);

                int row1 = cmd1.ExecuteNonQuery();

                if (row1 > 0)
                {
                    MessageBox.Show("Đặt Phòng Thành Công");
                    UpdateStatusRoom();
                    ShowAllCustomer();
                    ShowAllPhong();
                    ShowDetailRoom();
                    SelectValueRoom();
                    ShowAllDatPhong();
                }

            }
        }

        string idRoom ;
        string status;
        private void ShowDetailRoom()
        {

            if (dvgRoom.CurrentRow != null)
            {
                var row = dvgRoom.CurrentRow;
                status = row.Cells[3].Value.ToString();
                if (status == "Còn Phòng")
                {
                    int max = int.Parse(row.Cells[2].Value.ToString());
                    int maxPrice = int.Parse(row.Cells[8].Value.ToString());
                    txtIdPhong.Text = row.Cells[0].Value.ToString();
                    idRoom = txtIdPhong.Text;
                    txtPrice.Text = row.Cells[8].Value.ToString();
                    numNguoiToiDa.Maximum = max;
                }
                else
                {
                    MessageBox.Show("Phòng Này Không Còn Trống");
                }
            }
        }

        private void dvgRoom_Click(object sender, EventArgs e)
        {
            ShowDetailRoom();

        }

        private void SelectValueRoom()
        {
            
        }


        private int UpdateStatusRoom()
        {
            SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
            cmd.CommandText = "UpdateStatusRoom";
            cmd.CommandType = CommandType.StoredProcedure;
            // gán giá trị
            cmd.Parameters.AddWithValue("@status", 0);
            cmd.Parameters.AddWithValue("@idRoom", idRoom);

            int row = cmd.ExecuteNonQuery();

            return row;
        }

        private int InsertDatPhong(string idCus)
        {
            SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
            cmd.CommandText = "InsertDatPhong";
            cmd.CommandType = CommandType.StoredProcedure;
            // gán giá trị
            cmd.Parameters.AddWithValue("@idCustomer", idCus);
            cmd.Parameters.AddWithValue("@roomId", txtIdPhong.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cmd.Parameters.AddWithValue("@startDate", dateStart.Value);
            cmd.Parameters.AddWithValue("@endDate", dateEnd.Value);
            cmd.Parameters.AddWithValue("@status", 1);

            int row = cmd.ExecuteNonQuery();

            return row;
        }

        private void cbxIdPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
