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

namespace Winform.Shared
{
    class GetData 
    {
        private string nameProcedure;
        private string nameTable;

        public static SqlCommand com;
        public static SqlDataAdapter ad;
        public static DataTable dt;
        // DataTable table;
        public static BindingSource code;
        public static SqlCommandBuilder bd;

        public string NameTable
        {
            get { return nameTable; }
            set { nameTable = value; }
        }


        public string NameProcedure
        {
            get { return nameProcedure; }
            set { nameProcedure = value; }
        }

        public GetData(string nameProcedure, string nameTable)
        {
            this.nameProcedure = nameProcedure;
            this.nameTable = nameTable;
        }

        public DataSet GetListData(DataSet ds)
        {
            SqlDataAdapter sql = new SqlDataAdapter(NameProcedure, SQLConnectionDatabase.Connection);
            sql.SelectCommand.CommandType = CommandType.StoredProcedure;
            sql.Fill(ds, NameTable);
            
            return ds;
        }


    }
}
