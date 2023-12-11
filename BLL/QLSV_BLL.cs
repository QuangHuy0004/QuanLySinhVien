using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.IO;
using NPOI.Util;
using System.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using MathNet.Numerics.Distributions;
using System.Globalization;

namespace BLL
{
    public class QLSV_BLL
    {
        private QLSV_DAL dal = new QLSV_DAL();

       
        private string ToTitleCase(string input)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input);
        }
        public List<Studen> LayDuLieu()
        {
            return dal.LayDuLieu();
        }

        public string ThemSinhVien(Studen st, DataGridView dataGridView1)
        {
            if (st.id == "" || st.name == "")
                return "empty";
            foreach (char ch in st.id)
            {
                if (!(char.IsDigit(ch)))
                    return "notnumber";
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ColumnID"].Value.ToString() == st.id)
                    return "duplicate";
            }
            return dal.ThemSinhVien(st);
        }

        public string XoaSinhVien(Studen st, DataGridView dataGridView1)
        {
            return dal.XoaSinhVien(st);
        }

        public string XoaTatCa()
        {
            return dal.XoaTatCa();
        }

        public string SuaSinhVien(Studen st1, Studen st2)
        {
            if (st1.name == "")
                return "notData";
            if (ChinhSua(st1, st2) == "true")
                return "notChange";
            return dal.SuaSinhVien(st1);
        }

        private string ChinhSua(Studen st1, Studen st2)
        {
            string kq = "true";
            if (st2.name != st1.name)
                return "false";
            if (st2.dateOfBirth != st1.dateOfBirth)
                return "false";
            if (st2.gender != st1.gender)
                return "false";
            if (st2.khoa != st1.khoa)
                return "false";
            if (st2.img != st1.img)
                return "false";
            return kq;
        }

        public void ExportToExcel(DataGridView dataGridView, string filePath)
        {
            // Tạo một tệp Excel
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("Sheet1");

            // Tạo tiêu đề cột
            IFont font = workbook.CreateFont();
            font.FontHeightInPoints = 12;
            font.IsBold = true;

            ICellStyle cellStyle = workbook.CreateCellStyle();
            cellStyle.SetFont(font);

            // Tạo dòng tiêu đề (header row) và đặt kiểu cho các ô cột
            IRow headerRow = sheet.CreateRow(0);
            for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
            {
                NPOI.SS.UserModel.ICell cell = headerRow.CreateCell(i);
                cell.SetCellValue(dataGridView.Columns[i].HeaderText);
                cell.CellStyle = cellStyle; // Đặt kiểu cho ô cột

                // Điều chỉnh độ rộng cột (tuỳ chọn)
                sheet.SetColumnWidth(i, 15 * 256); // 15 ký tự
            }

            // Sao chép dữ liệu từ DataGridView vào tệp Excel
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < dataGridView.Columns.Count - 1; j++)
                {
                    DataGridViewCell cell = dataGridView[j, i];
                    row.CreateCell(j).SetCellValue(cell.Value.ToString());
                }
            }

            // Lưu tệp Excel
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fs);
            }

            MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel thành công.");
        }
        public void ExportToPDF(DataGridView dataGridView, string filePath)
        {
            PdfDocument pdfDocument = new PdfDocument();
            PdfPage pdfPage = pdfDocument.AddPage();
            XGraphics graphics = XGraphics.FromPdfPage(pdfPage);
            XFont font = new XFont("Arial", 12, XFontStyle.Bold);
            pdfPage.Width = XUnit.FromMillimeter(210);
            pdfPage.Height = XUnit.FromMillimeter(297);

            XTextFormatter tf = new XTextFormatter(graphics);

            int y = 40;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string ma = row.Cells[0].Value.ToString();
                    string ten = row.Cells[1].Value.ToString();
                    string ngaySinh = row.Cells[2].Value.ToString();
                    string gioiTinh = row.Cells[3].Value.ToString();
                    string khoa = row.Cells[4].Value.ToString();
                    //string sdt = row.Cells["PHONE"].Value.ToString();
                    string img = row.Cells[5].Value.ToString();

                    tf.DrawString("----------------------------------------------", font, XBrushes.Black,
                        new XRect(40, y, pdfPage.Width.Point, pdfPage.Height.Point),
                        XStringFormats.TopLeft);
                    y += 20;
                    tf.DrawString("Mã số SV: " + ma, font, XBrushes.Black,
                        new XRect(40, y, pdfPage.Width.Point, pdfPage.Height.Point),
                        XStringFormats.TopLeft);
                    y += 20;

                    tf.DrawString("Tên: " + ten, font, XBrushes.Black,
                        new XRect(40, y, pdfPage.Width.Point, pdfPage.Height.Point),
                        XStringFormats.TopLeft);
                    y += 20;

                    tf.DrawString("Ngày sinh: " + ngaySinh, font, XBrushes.Black,
                        new XRect(40, y, pdfPage.Width.Point, pdfPage.Height.Point),
                        XStringFormats.TopLeft);
                    y += 20;
                    tf.DrawString("Giới tính: " + gioiTinh, font, XBrushes.Black,
                        new XRect(40, y, pdfPage.Width.Point, pdfPage.Height.Point),
                        XStringFormats.TopLeft);
                    y += 20;
                    tf.DrawString("Khoa: " + khoa, font, XBrushes.Black,
                       new XRect(40, y, pdfPage.Width.Point, pdfPage.Height.Point),
                       XStringFormats.TopLeft);
                  
                    y += 20;
                    tf.DrawString("Hình ảnh: ", font, XBrushes.Black, new XRect(40, y, pdfPage.Width.Point, pdfPage.Height.Point),
                   XStringFormats.TopLeft);
                    if (img != "")
                    {
                        try
                        {

                            XImage image = XImage.FromFile($"../../Images/{img}");
                            double imageWidth = 100; // Điều chỉnh kích thước hình ảnh
                            double imageHeight = 100;
                            graphics.DrawImage(image, 100, y + 5, imageWidth, imageHeight);
                        }
                        catch
                        {

                        }
                    }
                    y += 150; // Khoảng cách giữa các dòng dữ liệu
                }
                if (y > pdfPage.Height - 100)
                {
                    // Không đủ chỗ, thêm trang mới
                    pdfPage = pdfDocument.AddPage();
                    pdfPage.Width = XUnit.FromMillimeter(210);
                    pdfPage.Height = XUnit.FromMillimeter(297);
                    graphics = XGraphics.FromPdfPage(pdfPage);
                    tf = new XTextFormatter(graphics);
                    y = 40; // Điểm bắt đầu trên trang mới
                }
            }

            pdfDocument.Save(filePath);
        }

    }
}
