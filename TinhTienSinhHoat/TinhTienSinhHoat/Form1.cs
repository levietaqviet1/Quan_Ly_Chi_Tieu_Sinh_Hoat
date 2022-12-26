using System.Windows.Forms;
using TinhTienSinhHoat.Logic;
using TinhTienSinhHoat.Models;
using System.IO; 
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using Microsoft.Office.Interop.Excel;
using System.Data;
using DataTable = System.Data.DataTable;

namespace TinhTienSinhHoat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        QLLoaiChiTieu qLLoaiChiTieu = new QLLoaiChiTieu();
        QLChiTieu qLChiTieu = new QLChiTieu();

        public void load()
        { 
            cboLoaiChiTieu.DataSource = qLLoaiChiTieu.getAll();
            cboLoaiChiTieu.DisplayMember = "TenChiTieu";
            cboLoaiChiTieu.ValueMember = "LoaiChiTieuId";

            List<LoaiChiTieu> listChiTieu = qLLoaiChiTieu.getAll();
            LoaiChiTieu loaiChiTieu = new LoaiChiTieu();
            loaiChiTieu.LoaiChiTieuId = 0;
            loaiChiTieu.TenChiTieu = "All";
            listChiTieu.Insert(0, loaiChiTieu);
            cboLoaiSe.DataSource = listChiTieu;
            cboLoaiSe.DisplayMember = "TenChiTieu";
            cboLoaiSe.ValueMember = "LoaiChiTieuId";
            dtDen.Text = "" + qLChiTieu.getAll().Max(x => x.ThoiGian);
            dtTu.Text = "" + qLChiTieu.getAll().Min(x => x.ThoiGian);
            var data = qLChiTieu.getAll()
                .Where(x => x.ThoiGian >= DateTime.Parse(dtTu.Text) && x.ThoiGian <= DateTime.Parse(dtDen.Text)).Select(x => new
            {
                x.Id,
                x.MucDichChiTieu,
                x.GiaTien,
                x.LoaiChiTieuId,
                tenChiTieu = x.LoaiChiTieu.TenChiTieu,
                x.ThoiGian
            }).ToList();
            if (int.Parse(cboLoaiSe.SelectedValue.ToString()) != 0)
            {
                data = data.Where(x => x.LoaiChiTieuId == int.Parse(cboLoaiSe.SelectedValue.ToString())).ToList();
            }
            if(data.Count > 0)
            {
                int sum = 0;
                foreach (var item in data)
                {
                    sum += int.Parse(item.GiaTien.ToString());
                } 
                labelTong.Text = "Tổng : "+sum;
            }
            dgv.DataSource = data;
        }
        public void loadAfter()
        {
            var data = qLChiTieu.getAll()
               .Where(x => x.ThoiGian >= DateTime.Parse(dtTu.Text) && x.ThoiGian <= DateTime.Parse(dtDen.Text)).Select(x => new
           {
               x.Id,
               x.MucDichChiTieu,
               x.GiaTien,
               x.LoaiChiTieuId,
               tenChiTieu = x.LoaiChiTieu.TenChiTieu,
               x.ThoiGian
           }).ToList();
            if (int.Parse(cboLoaiSe.SelectedValue.ToString()) != 0)
            {
                data = data.Where(x => x.LoaiChiTieuId == int.Parse(cboLoaiSe.SelectedValue.ToString())).ToList();
            }
            if (data.Count > 0)
            {
                int sum = 0;
                foreach (var item in data)
                {
                    sum += int.Parse(item.GiaTien.ToString());
                }
                labelTong.Text = "Tổng : " + sum;
            }
            dgv.DataSource = data;
        }
        private void loadData_Click(object sender, EventArgs e)
        {
            var data = qLChiTieu.getAll().Select(x => new
            {
                x.Id,
                x.MucDichChiTieu,
                x.GiaTien,
                x.LoaiChiTieuId,
                tenChiTieu = x.LoaiChiTieu.TenChiTieu,
                x.ThoiGian
            }).ToList();
            if (data.Count > 0)
            {
                int sum = 0;
                foreach (var item in data)
                {
                    sum += int.Parse(item.GiaTien.ToString());
                }
                labelTong.Text = "Tổng : " + sum;
            }
            dgv.DataSource = data;
            dtDen.Text = "" + data.Max(x=> x.ThoiGian);
            dtTu.Text = "" + data.Min(x => x.ThoiGian);
            cboLoaiSe.Text = "All";
        }
         public void search()
        {
            var data = qLChiTieu.getAll()
                .Where(x =>  x.ThoiGian >= DateTime.Parse(dtTu.Text) && x.ThoiGian <= DateTime.Parse(dtDen.Text)).Select(x => new
            {
                x.Id,
                x.MucDichChiTieu,
                x.GiaTien,
                x.LoaiChiTieuId,
                tenChiTieu = x.LoaiChiTieu.TenChiTieu,
                x.ThoiGian
            }).ToList();
            try
            {
                if (int.Parse(cboLoaiSe.SelectedValue.ToString()) != 0)
                {
                    data = data.Where(x => x.LoaiChiTieuId == int.Parse(cboLoaiSe.SelectedValue.ToString())).ToList();
                }
            }
            catch (Exception)
            {  
            }
            if (data.Count > 0)
            {
                int sum = 0;
                foreach (var item in data)
                {
                    sum += int.Parse(item.GiaTien.ToString());
                }
                labelTong.Text = "Tổng : " + sum;
            }
            else
            {
                labelTong.Text = "";
            }
            dgv.DataSource = data;
        }
        private void resetInput_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtMucDich.Text = "";
            numGiaTien.Value = 0;
            cboLoaiChiTieu.DataSource = qLLoaiChiTieu.getAll();
            cboLoaiChiTieu.DisplayMember = "TenChiTieu";
            cboLoaiChiTieu.ValueMember = "LoaiChiTieuId";
            dtThoiGian.Text = DateTime.Now + "";
        }


        private void Add_Click(object sender, EventArgs e)
        {
            ChiTieu chiTieu = new ChiTieu();
            string mess = "";
            chiTieu.MucDichChiTieu = txtMucDich.Text;
            if (String.IsNullOrEmpty(chiTieu.MucDichChiTieu))
            {
                mess += "Phải Nhập Mục Đích\n";
            } 
            chiTieu.GiaTien = int.Parse(numGiaTien.Value.ToString());
            if (chiTieu.GiaTien < 0)
            {
                mess += "Số Tiền phải từ 0 trở lên\n";
            } 
            string loaiChiTieu = cboLoaiChiTieu.SelectedValue.ToString();
            if (String.IsNullOrEmpty(loaiChiTieu))
            {
                mess += "Vui long loadData để chọn thư mục\n";
            } 
            chiTieu.ThoiGian = DateTime.Parse(dtThoiGian.Text);
            if (!mess.Equals(""))
            {
                MessageBox.Show(mess, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                chiTieu.LoaiChiTieuId = int.Parse(loaiChiTieu);
                qLChiTieu.Insert(chiTieu);
                cboLoaiSe.Text = cboLoaiChiTieu.Text;
                dtTu.Text = dtThoiGian.Text;
                dtDen.Text = dtThoiGian.Text;
                loadAfter();
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            if (!String.IsNullOrEmpty(id))
            {
                qLChiTieu.DeleteByID(int.Parse(id));
                cboLoaiSe.Text = cboLoaiChiTieu.Text;
                loadAfter();
            }
        }
        
       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtID.Text))
            {
            ChiTieu chiTieu = new ChiTieu();
                chiTieu.GiaTien = int.Parse(numGiaTien.Value.ToString());
            chiTieu.MucDichChiTieu = txtMucDich.Text;
            string mess = "";
            chiTieu.Id = int.Parse(txtID.Text);
            if (String.IsNullOrEmpty(chiTieu.MucDichChiTieu))
            {
                mess += "Phải Nhập Mục Đích\n";
            }
            if (chiTieu.GiaTien < 0)
            {
                mess += "Số Tiền phải từ 0 trở lên\n";
            }
            string loaiChiTieu = cboLoaiChiTieu.SelectedValue.ToString();
            if (String.IsNullOrEmpty(loaiChiTieu))
            {
                mess += "Vui long loadData để chọn thư mục\n";
            }
            chiTieu.ThoiGian = DateTime.Parse(dtThoiGian.Text);
            if (!mess.Equals(""))
            {
                MessageBox.Show(mess, "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                chiTieu.LoaiChiTieuId = int.Parse(loaiChiTieu);
                qLChiTieu.Edit(chiTieu);
                cboLoaiSe.Text = cboLoaiChiTieu.Text;
                loadAfter();
            }
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Quản lý";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Columns.AutoFit();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        private void btnGenExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Browse Excel Files";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dgv, saveFileDialog.FileName);
            }
        }

        private void dtTu_ValueChanged(object sender, EventArgs e)
        {
            search();
        }

        private void dtDen_ValueChanged(object sender, EventArgs e)
        {
            search();
        }

        private void cboLoaiSe_TextChanged(object sender, EventArgs e)
        {
            search();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgv.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            ChiTieu chiTieu = qLChiTieu.getById(int.Parse(id));
            txtID.Text =""+ chiTieu.Id;
            txtMucDich.Text = "" + chiTieu.MucDichChiTieu;
            numGiaTien.Value = (decimal)chiTieu.GiaTien;
            cboLoaiChiTieu.Text = chiTieu.LoaiChiTieu.TenChiTieu;
            dtThoiGian.Text =""+ chiTieu.ThoiGian;

        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.Title = "Browse Excel Files";
            openFileDialog.Filter = "txt files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            List<ChiTieu> chiTieuList = new List<ChiTieu>();
            // mở file excel 
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(openFileDialog.FileName)))
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
                DataTable dataTable = new DataTable();
                List<String> lis = new List<string>();
                
                for (int i = excelWorksheet.Dimension.Start.Column; i <= excelWorksheet.Dimension.End.Column; i++)
                {
                    dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
                }
              
                for (int i = excelWorksheet.Dimension.Start.Row+1; i <= excelWorksheet.Dimension.End.Row; i++)
                {
                    List<String> listRow = new List<String>();
                    for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
                    {
                        listRow.Add(excelWorksheet.Cells[i, j].Value.ToString());
                       // MessageBox.Show(excelWorksheet.Cells[i, j].Value.ToString());
                    }
                    dataTable.Rows.Add(listRow.ToArray());
                }
                dgv.DataSource = dataTable;

            }
            // var package = new ExcelPackage(new FileInfo("ImportData.xlsx"));
        }
    }
}