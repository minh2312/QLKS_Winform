using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Shared;
using System.Data.SqlClient;
using Winform.Connect;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using Winform.ExportExcel;
using System.Diagnostics;

namespace Winform.QLDatPhong
{
    public partial class TraPhong : Form
    {
        public TraPhong()
        {
            InitializeComponent();
        }

        private void TraPhong_Load(object sender, EventArgs e)
        {
            ShowAllDatPhong();
            ShowDetailRoom();
        }

        private void ShowAllDatPhong()
        {
            DataSet ds = new DataSet();
            GetData data = new GetData("GetAllDatPhong", "DatPhong");
            data.GetListData(ds);
            dvgDatPhong.DataSource = ds.Tables["DatPhong"];
        }

        private void dvgDatPhong_Click(object sender, EventArgs e)
        {
            ShowDetailRoom();
        }

        private void TinhDate(String id)
        {
            DateTime ngaymuon = Convert.ToDateTime("05/09/2017");
            DateTime ngaytra = Convert.ToDateTime("15/09/2017");
            TimeSpan Time = ngaytra - ngaymuon;
            int TongSoNgay = Time.Days;
            MessageBox.Show(TongSoNgay.ToString());
        }




        string idRoom;
        private void ShowDetailRoom()
        {
            if (dvgDatPhong.CurrentRow !=null)
            {
                var row = dvgDatPhong.CurrentRow;
                String id = row.Cells[0].Value.ToString();
                SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
                cmd.CommandText = "GetDatPhongById";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    //đọc dữ liệu ra form
                    if (dr.Read())
                    {
                        txtIdRoom.Text = dr.GetInt32(3).ToString(); idRoom = txtIdRoom.Text;
                        lbNameRoom.Text = dr.GetString(4);
                        txtIdCustomer.Text = dr.GetString(1);
                        lbNameCus.Text = dr.GetString(2);
                        dateNgayDat.Value = dr.GetDateTime(6);
                        dateNgayTra.Value = dr.GetDateTime(7);
                        txtPrice.Text = dr.GetDouble(5).ToString();


                        DateTime ngaymuon = Convert.ToDateTime(dateNgayDat.Value);
                        DateTime ngaytra = Convert.ToDateTime(dateNgayTra.Value);
                        TimeSpan Time = ngaytra - ngaymuon;

                        int TongSoNgay = Time.Days;
                        double price = double.Parse(txtPrice.Text);

                        lbSoNgayThue.Text = TongSoNgay.ToString() + " Ngày";
                        double totalPrice = TongSoNgay * price;

                        txtTotalPrice.Text = totalPrice.ToString();

                    }
                }
            }
            
        }

        private void ExportExcel(DataGridView g, string duongDan,string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }

            for (int j = 0; j < g.Rows.Count; j++)
            {
                for (int x = 0; x < g.Rows.Count; x++)
                {
                    if (g.Rows[j].Cells[x].Value != null)
                    {
                        obj.Cells[j + 2, x + 1] = g.Rows[j].Cells[j].Value.ToString();
                    }
                }
            }

            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            string nameKH = lbNameCus.Text;
            string ngayThue = dateNgayDat.Value.ToString();
            string ngayTra = dateNgayTra.Value.ToString();
            string priceRoom = txtPrice.Text;
            string soNgayThue = lbSoNgayThue.Text;
            string totalPrice = txtTotalPrice.Text;
            string duongDan = "C:\\Users\\Admin\\New folder (2)\\BTL_Winform\\Excel\\";
            string nameFile = "HoaDon";
            Xuat_Excel.Export_Hoadon(dvgDatPhong, nameKH, ngayThue, ngayTra, priceRoom, soNgayThue, totalPrice, duongDan, nameFile);
            string mofile = duongDan + nameFile + ".xlsx";
            Process.Start(@"" + mofile);

        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            if (dvgDatPhong.CurrentRow != null)
            {
                var row = dvgDatPhong.CurrentRow;
                String id = row.Cells[0].Value.ToString();
                SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
                cmd.CommandText = "ThanhToan";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);

                int capNhap = cmd.ExecuteNonQuery();

                if (capNhap > 0)
                {

                        UpdateStatusRoom(idRoom);

                        MessageBox.Show("Thanh Toán Thành Công");
                        ShowAllDatPhong();
                        ShowDetailRoom();
                }
            }
        }

        private void UpdateStatusRoom(string id)
        {
            SqlCommand cmd1 = SQLConnectionDatabase.Connection.CreateCommand();
            cmd1.CommandText = "UpdateStatusRoom";
            cmd1.CommandType = CommandType.StoredProcedure;
            // gán giá trị
            cmd1.Parameters.AddWithValue("@status", 1);
            cmd1.Parameters.AddWithValue("@idRoom", id);

            int row = cmd1.ExecuteNonQuery();
            ShowAllDatPhong();
            ShowDetailRoom();
        }
    }
}
