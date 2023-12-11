using DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using Microsoft.Office.Interop.Word;
using Application = Microsoft.Office.Interop.Word.Application;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;

namespace BLL
{
    public partial class QUANTRIVIEN : Form
    {
        string tenhinhanh = "";
        QLSV_BLL bal = new QLSV_BLL();
        List<Studen> lstSt = new List<Studen>();
        string DuongDanTrenMayTinh = "";
        string DuongDanDuAn = "";
        int idx;
        public QUANTRIVIEN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstSt = bal.LayDuLieu();
            if (lstSt == null)
            {
                // If there's no data, disable the buttons
                btEdit.Enabled = false;
                btDel.Enabled = false;
                btnDelete_ALL.Enabled = false;
                return;
            }

            foreach (Studen studen in lstSt)
            {
                dataGridView1.Rows.Add(studen.id, studen.name, studen.dateOfBirth, studen.gender, studen.khoa, studen.img);
            }

            if (dataGridView1.Rows.Count > 0)
            {
                // Enable the buttons since there is data
                btnDelete_ALL.Enabled = true;
                btDel.Enabled = true;
                btEdit.Enabled = true;
            }
            else
            {
                // If no data, disable the buttons
                btEdit.Enabled = false;
                btDel.Enabled = false;
                btnDelete_ALL.Enabled = false;
            }
        }



        private string GioiTinh(bool gender)
        {
            if (gender)
                return "Nữ";
            return "Nam";
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            Studen st = LayThongTinTuForm("them");
            string ketqua = bal.ThemSinhVien(st, dataGridView1);
            switch (ketqua)
            {
                case "empty":
                    MessageBox.Show("MSSV và Họ tên không được để trống!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "notnumber":
                    MessageBox.Show("MSSV không được chứa chữ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "duplicate":
                    MessageBox.Show("Trùng mã sô sinh viên!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "success":
                    if (tenhinhanh != "")
                    {
                        DuongDanDuAn = System.IO.Path.Combine("../../Images", st.img);
                        File.Copy(DuongDanTrenMayTinh, DuongDanDuAn, true);
                    }
                    tenhinhanh = "";
                    dataGridView1.Rows.Add(st.id, st.name, st.dateOfBirth, st.gender, st.khoa, st.img);
                    btDel.Enabled = true;
                    btnDelete_ALL.Enabled = true;
                    //Tự động nhảy xuống hàng mới thêm vào
                    int lastRowIndex = dataGridView1.Rows.Count - 1;
                    dataGridView1.CurrentCell = dataGridView1[0, lastRowIndex];
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                default:
                    return;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            dataGridView1.Rows[idx].Selected = true;
            txtID.Enabled = false;
            btEdit.Enabled = true;
            btDel.Enabled = true;
            txtID.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            txtUser.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();

            // Chuyển đổi giá trị ngày sinh từ chuỗi sang đối tượng DateTime
            string ngaySinhString = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            if (DateTime.TryParse(ngaySinhString, out DateTime ngaySinh))
            {
                dtpDate.Value = ngaySinh;
            }
            else
            {
                // Xử lý trường hợp ngày sinh không hợp lệ
                MessageBox.Show("Ngày sinh không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Gán ngày mặc định hoặc thực hiện các hành động xử lý khác nếu cần
                dtpDate.Value = DateTime.Now;
            }

            string gioitinh = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            if (gioitinh == "Nam")
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            cbbFaculty.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();

            if (dataGridView1.Rows[idx].Cells[5].Value.ToString() == "")
                pbImg.ImageLocation = null;
            else
            {
                pbImg.ImageLocation = $"../../Images/{dataGridView1.Rows[idx].Cells[5].Value.ToString()}";
                pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            tenhinhanh = "";
        }


        private void btClear_Click(object sender, EventArgs e)
        {
            DatVeMacDinh();
            dataGridView1.CurrentCell = null;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Studen studen1 = LayThongTinTuForm("sua");
            Studen studen2 = LayThongTinTuDataGrid();
            string ketqua = bal.SuaSinhVien(studen1, studen2);
            switch (ketqua)
            {
                case "notData":
                    MessageBox.Show("Dữ liệu không được để trống!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case "notChange":
                    MessageBox.Show("Không có gì để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                case "success":
                    if (tenhinhanh != "")
                    {
                        if (studen2.img != "")
                            File.Delete($"../../Images/{studen2.img}");
                        DuongDanDuAn = System.IO.Path.Combine("../../Images", studen1.img);
                        File.Copy(DuongDanTrenMayTinh, DuongDanDuAn, true);
                    }
                    tenhinhanh = "";
                    GanDuLieuVaoGrid(studen1);
                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                default:
                    return;
            }
        }

        private void GanDuLieuVaoGrid(Studen st1)
        {
            dataGridView1.Rows[idx].Cells[1].Value = st1.name;
            dataGridView1.Rows[idx].Cells[2].Value = st1.dateOfBirth;
            dataGridView1.Rows[idx].Cells[3].Value = st1.gender;
            dataGridView1.Rows[idx].Cells[4].Value = st1.khoa;
            dataGridView1.Rows[idx].Cells[5].Value = st1.img;
        }

        private void DatVeMacDinh()
        {
            txtID.Text = "";
            txtUser.Text = "";
            rbMale.Checked = true;
            dtpDate.Text = "01/01/2004";
            cbbFaculty.Text = "Công nghệ thông tin";
            pbImg.ImageLocation = "";
            DuongDanTrenMayTinh = "";
            txtID.Enabled = true;
            btEdit.Enabled = false;
            btDel.Enabled = false;
        }
        private Studen LayThongTinTuForm(string action)
        {
            Studen studen = new Studen();
            studen.id = txtID.Text;
            studen.name = txtUser.Text;
            studen.dateOfBirth = dtpDate.Text;
            studen.gender = GioiTinh(rbFemale.Checked);
            studen.khoa = cbbFaculty.Text;
            if (action == "them")
                studen.img = "";
            else studen.img = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            if (tenhinhanh != "")
            {
                DateTime currentDateTime = DateTime.Now;
                studen.img = currentDateTime.ToString("MMddHHmmssfff") + tenhinhanh;
            }
            return studen;
        }
        private Studen LayThongTinTuDataGrid()
        {
            Studen studen = new Studen();
            studen.id = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            studen.name = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            studen.dateOfBirth = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            studen.gender = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            studen.khoa = dataGridView1.Rows[idx].Cells[4].Value.ToString();
            studen.img = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            return studen;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            Studen st = new Studen();
            st.id = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            st.img = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            string ketqua = bal.XoaSinhVien(st, dataGridView1);
            switch (ketqua)
            {
                case "success":
                    if (dataGridView1.Rows.Count == 1)
                    {
                        btEdit.Enabled = false;
                        btnDelete_ALL.Enabled = false;
                        btDel.Enabled = false;
                        txtID.Text = "";
                        txtID.Enabled = true;
                        txtUser.Text = "";
                        rbMale.Checked = true;
                        dtpDate.Text = "01/01/2004";
                        pbImg.ImageLocation = "";
                        cbbFaculty.Text = "Công nghệ thông tin";
                    }
                    dataGridView1.Rows.RemoveAt(idx);
                    if (st.img != "")
                        File.Delete($"../../Images/{st.img}");
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                default:
                    return;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (kq == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btChoose_Click(object sender, EventArgs e)
        {
            pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImg.ImageLocation = dlg.FileName;
                DuongDanTrenMayTinh = pbImg.ImageLocation;
                tenhinhanh = System.IO.Path.GetFileName(pbImg.ImageLocation);
            }
        }

        private void btnDelete_ALL_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa hết không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (kq == DialogResult.OK)
                {
                    string ketqua = bal.XoaTatCa();
                    switch (ketqua)
                    {
                        case "success":
                            DatVeMacDinh();

                            btnDelete_ALL.Enabled = false;
                            //Xóa ảnh khỏi thư mục
                            for (int row = 0; row < dataGridView1.Rows.Count; row++)
                            {
                                string tenanh = dataGridView1.Rows[row].Cells[5].Value.ToString();
                                if (tenanh != "")
                                    File.Delete($"../../Images/{tenanh}");
                            }
                            dataGridView1.Rows.Clear();

                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        default:
                            return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnExportEX_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Excel Files|*.xlsx";
            saveDialog.FileName = "exported_data.xlsx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                bal.ExportToExcel(dataGridView1, saveDialog.FileName);
            }
        }



        private void btnImportEx_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Excel Files|*.xlsx";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Gọi hàm ImportFromExcel để đọc dữ liệu từ file Excel
                    List<Studen> importedData = ImportFromExcel(openDialog.FileName);

                    // Kiểm tra nếu có dữ liệu được đọc
                    if (importedData != null && importedData.Count > 0)
                    {
                        

                        // Thêm dữ liệu mới vào dataGridView1
                        foreach (Studen studen in importedData)
                        {
                            dataGridView1.Rows.Add(studen.id, studen.name, studen.dateOfBirth, studen.gender, studen.khoa, studen.img);
                        }

                        // Hiển thị thông báo thành công
                        MessageBox.Show("Nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Hiển thị thông báo nếu không có dữ liệu được đọc
                        MessageBox.Show("Không có dữ liệu để nhập vào hoặc định dạng không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có lỗi xảy ra trong quá trình đọc file Excel
                    MessageBox.Show("Lỗi khi đọc file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public List<Studen> ImportFromExcel(string filePath)
        {
            try
            {
                List<Studen> importedData = new List<Studen>();
                List<string> listID = new List<string>();
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook = new XSSFWorkbook(fs);
                    ISheet sheet = workbook.GetSheetAt(0); // Lấy sheet đầu tiên

                    for (int i = 1; i <= sheet.LastRowNum; i++)
                    {
                        IRow row = sheet.GetRow(i);

                        if (row != null)
                        {
                            Studen studen = new Studen();

                            studen.id = row.GetCell(0)?.ToString() ?? "";
                            studen.name = row.GetCell(1)?.ToString() ?? "";
                            studen.dateOfBirth = row.GetCell(2).ToString() ?? "";
                            studen.gender = row.GetCell(3)?.ToString() ?? "";
                            studen.khoa = row.GetCell(4)?.ToString() ?? "";
                            studen.img = row.GetCell(5)?.ToString() ?? "";

                            // Add data to the database
                            string result = bal.ThemSinhVien(studen, dataGridView1);
                            if (result == "success")
                            {
                                importedData.Add(studen);
                                btnDelete_ALL.Enabled = true;
                            }
                            else
                            {
                                listID.Add(studen.id);
                            }
                        }
                    }
                    if (listID.Count > 0)
                    {
                        string s = "";
                        foreach (var id in listID)
                        {
                            s += id + ",";
                        }
                        s = s.TrimEnd(',');
                        MessageBox.Show($"Bạn bị lỗi ở các dòng có massv:ad {s} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                return importedData;
            }
            catch (Exception ex)
            {
                // Xử lý lỗi, ví dụ: thông báo lỗi hoặc ghi log
                MessageBox.Show("Lỗi khi đọc file Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gbGender_Enter(object sender, EventArgs e)
        {

        }

        private void button_xuatWord(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Word Files|*.docx";
            saveDialog.FileName = "exported_data.docx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    ExportToWord(lstSt, saveDialog.FileName);

                    MessageBox.Show("Xuất dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất dữ liệu sang file Word: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportToWord(List<Studen> students, string filePath)
        {
            var wordApp = new Application();

            var doc = wordApp.Documents.Add();

            var title = doc.Paragraphs.Add();
            title.Range.Text = "Danh sách sinh viên";
            title.Range.Font.Size = 16;
            title.Range.Font.Bold = 1;
            title.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            title.Range.InsertParagraphAfter();

            foreach (var student in students)
            {
                var paragraph = doc.Paragraphs.Add();
                paragraph.Range.Text = $"ID: {student.id}, Name: {student.name}, Date of Birth: {student.dateOfBirth}, Gender: {student.gender}, Faculty: {student.khoa}, Image: {student.img}";
                paragraph.Range.InsertParagraphAfter();
            }

            doc.SaveAs2(filePath);

            wordApp.Quit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Title = "Export PDF File",
                Filter = "PDF Files|*.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;


                bal.ExportToPDF(dataGridView1, saveFileDialog.FileName);

                MessageBox.Show("Exported successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
