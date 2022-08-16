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
using Winform.QuanLy;
using Winform.Shared;
using Winform.QLDatPhong;

namespace Winform
{
    public partial class FrmMain : Form
    {
        private string name;
        private string id;
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(string id) : this()
        {
            this.id = id;
            //txtHello.Text = "Chào :" +this.name;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            
        }

        private void trvSidebar_AfterSelect(object sender, TreeViewEventArgs e)
        {
                //lấy nút được kích
            TreeNode node = e.Node;
            if (node.Tag.ToString().Equals("1"))
            {
                MessageBox.Show("Quản Lý Tầng");
            }else if (node.Tag.ToString().Equals("2"))
            {
                MessageBox.Show("Quản Lý Loại Phòng");
            }
        }

        private void QLTang_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("QLTang"))
            {
                Manager_Tang room = new Manager_Tang();
                room.MdiParent = this;
                room.Show();
            }
        }

        private bool CheckFormExist(string name)
        {
            bool flag = false;
            foreach (var f in this.MdiChildren)
            {
                if (f.Text == name)
                {
                    flag = true;
                    break;
                }
            }
            return flag;
        }

        private void QLLoaiPhong_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("QLLoaiPhong"))
            {
                QuanLyLoaiPhong room = new QuanLyLoaiPhong();
                room.MdiParent = this;
                room.Show();
            }
        }

        private void QLRoom_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("QLLoaiPhong"))
            {
                QuanLyRoom room = new QuanLyRoom();
                room.MdiParent = this;
                room.Show();
            }
        }

        //private void trvClass_AfterSelect(object sender, TreeViewEventArgs e)
        //{
        //    
        //}

        private void ShowRoom()
        {
            SqlDataAdapter sql = new SqlDataAdapter("GetTangAll", SQLConnectionDatabase.Connection);
            sql.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            sql.Fill(ds, "Tang");


        }

        private void QLDatPhong_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("QLDatPhong"))
            {
                DatPhong dt = new DatPhong(); ;
                dt.MdiParent = this;
                dt.Show();
            }
        }

        private void QLTraPhong_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("QLTraPhong"))
            {
                TraPhong tp = new TraPhong();
                tp.MdiParent = this;
                tp.Show();
            }
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            if (!CheckFormExist("changePass"))
            {
                ChangePass cs = new ChangePass(id);
                cs.MdiParent = this;
                cs.Show();
            }
        }
    }
}
