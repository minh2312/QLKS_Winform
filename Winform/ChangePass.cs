using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.Connect;

namespace Winform
{
    public partial class ChangePass : Form
    {
        private string id;
        public ChangePass()
        {
            InitializeComponent();
        }

        public ChangePass(string id) :this()
        {
            this.id = id;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = SQLConnectionDatabase.Connection.CreateCommand();
            cmd.CommandText = "CapNhapPassword";
            cmd.CommandType = CommandType.StoredProcedure;
            // gán giá trị
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pass", txtPassMoi.Text);

            //SqlDataReader dr = cmd.ExecuteReader();
            

            int row = cmd.ExecuteNonQuery();
            if (row > 0)
            {
                MessageBox.Show("Cập nhập thành công", "Thông Báo");
            }
        }

       

    }
}
