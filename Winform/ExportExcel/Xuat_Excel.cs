using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.Windows.Forms;


namespace Winform.ExportExcel
{
    class Xuat_Excel
    {
        public static void Export_Hoadon(DataGridView g, string tenkhach, string ngaythue, string ngaytra, string giaphong, string songaythue, string tongtien, string duongdan, string tenfile)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            obj.Range["A1:Z100"].Style.HorizontalAlignment = HorizontalAlignment.Center;
            obj.Range["A1:Z100"].ColumnWidth = 25;
            obj.Range["A1:z2"].Font.Size = 16;
            obj.Range["C3:D3"].Font.Size = 16;
            obj.Range["A6:z6"].Font.Size = 14;
            obj.Range["A1:Z100"].Font.Name = "Times new roman";
            obj.Range["A1:B3"].Font.Bold = true;
            obj.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            obj.Range["B1:B100"].ColumnWidth = 20;
            obj.Range["A1:B1"].MergeCells = true;
            obj.Range["A5:B5"].MergeCells = true;
            obj.Range["A6:B6"].MergeCells = true;
            obj.Range["A7:B7"].MergeCells = true;
            obj.Range["A8:B8"].MergeCells = true;
            obj.Range["A9:B9"].MergeCells = true;
            obj.Range["A10:B10"].MergeCells = true;
            obj.Range["A11:B11"].MergeCells = true;
            obj.Range["B13:C13"].MergeCells = true;
            obj.Range["C3:D3"].MergeCells = true;
            obj.Range["A2:B2"].MergeCells = true;
            obj.Range["D1:E1"].MergeCells = true;
            obj.Range["A1:B1"].Value = "Khách Sạn Hoàng Gia";
            obj.Range["D1:E1"].Value = "Thời gian: " + ngaytra;
            obj.Range["A2:B2"].Value = "Hà Nội";
            obj.Range["C3:D3"].Value = "HÓA ĐƠN THANH TOÁN";
            obj.Range["B13:C13"].Font.Size = 16;
            obj.Range["A5"].Value = "Tên khách: "; obj.Range["C5"].Value =  tenkhach;
            obj.Range["A6"].Value = "Ngày thuê phòng: "; obj.Range["C6"].Value = ngaythue;
            obj.Range["A7"].Value = "Ngày trả phòng: "; obj.Range["C7"].Value = ngaytra;
            obj.Range["A8"].Value = "Giá phòng: "; obj.Range["C8"].Value = giaphong + " / 1 ngày";
            obj.Range["A9"].Value = "Số ngày thuê: "; obj.Range["C9"].Value = songaythue + "(ngày)";
            obj.Range["C11"].Value = " tổng tiền: " + tongtien + "VNĐ";
            obj.ActiveWorkbook.SaveCopyAs(duongdan + tenfile + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }
    }
}
