using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class FrmSinhVien : Form
    {
        public static string masv_diem = "";
        public static string ten = "";
        public static string diachi = "";
        public static DateTime ngaysinh = DateTime.Now;
        public static string email = "";
        public static bool gioitinh = true;
        
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        private void dgSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button_Xoa.Enabled = true;
            button_XemDiem.Enabled = true;
            txtMaSV.Text = dgSinhVien.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtTen.Text = dgSinhVien.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtDiaChi.Text = dgSinhVien.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtEmail.Text = dgSinhVien.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtNgaySinh.Value = DateTime.ParseExact(dgSinhVien.Rows[e.RowIndex].Cells[5].FormattedValue.ToString(), "dd/MM/yyyy", null);

            masv_diem = dgSinhVien.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            ten = dgSinhVien.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            diachi = dgSinhVien.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            email = dgSinhVien.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            ngaysinh = DateTime.ParseExact(dgSinhVien.Rows[e.RowIndex].Cells[5].FormattedValue.ToString(), "dd/MM/yyyy", null);

            if (dgSinhVien.Rows[e.RowIndex].Cells[3].FormattedValue.ToString().Equals("Nam"))
            {
                btnNam.Checked = true;
                gioitinh = true;
            }
            else
            {
                btnNu.Checked = true;
                gioitinh = false;
            }
            FrmChiTietSinhVien frmsvdt = new FrmChiTietSinhVien();
            frmsvdt.Show();
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            button_XemDiem.Enabled = false;
            button_Xoa.Enabled = false; 
            LoadSV();
        }
        StudentManagementContext context = new StudentManagementContext();
        private void LoadSV(string ten = null, int gioitinh = -1)
        {
            List<SinhVien> list = context.SinhViens.ToList();
            if (ten != null)
            {
                list = list.Where(x=>x.Ten.ToLower().Contains(ten.ToLower())).ToList();
            }
            if (gioitinh != -1)
            {
                list = list.Where(x => x.GioiTinh== (gioitinh==1?true:false)).ToList();
            }
            dgSinhVien.DataSource = list.Select(item=> new { item.MaSv, item.Ten, item.DiaChi, item.StrGioitinh, item.Email, NgaySinh = item.NgaySinh.ToString("dd/MM/yyyy") }).ToList();
        }

        private void ClearText()
        {
            button_XemDiem.Enabled = false;
            button_Xoa.Enabled = false;
            txtMaSV.Text = "";
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtNgaySinh.Text = "";
            txtEmail.Text = "";
            btnNam.Checked = false;
            btnNu.Checked = false;
        }

        private void button_ThemMoi_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            string ten = txtTen.Text;
            string diachi = txtDiaChi.Text;
            DateTime ngaysinh = txtNgaySinh.Value;
            DateTime currentDate = DateTime.Today;
            var days = (currentDate - ngaysinh).TotalDays;
            string email = txtEmail.Text;
            var rg_email = new EmailAddressAttribute();
            bool gioitinh = true;
            if (btnNu.Checked == true)
            {
                gioitinh = false;
            }
            if (masv == null || ten == null || diachi == null || days < 6570 || rg_email.IsValid(email) == false)
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }
            else
            {
                var sv = context.SinhViens.Find(txtMaSV.Text);
                if (sv != null)
                {
                    updateSV(sv, ten, diachi, email, ngaysinh, gioitinh);
                }
                else
                {
                    addNewSV(masv, ten, diachi, email, ngaysinh, gioitinh);
                }
            }

        }



        private void addNewSV(string masv, string ten, string diachi, string email, DateTime ngaysinh, bool gioitinh)
        {
            SinhVien sv = new SinhVien()
            {
                MaSv = masv,
                Ten = ten,
                DiaChi = diachi,
                Email = email,
                NgaySinh = ngaysinh,
                GioiTinh = gioitinh,
            };
            context.SinhViens.Add(sv);
            int count = context.SaveChanges();
            if (count > 0)
            {
                LoadSV();
                MessageBox.Show("Thêm thành công!");
                ClearText();
            }
        }

        private void updateSV(SinhVien sv, string ten, string diachi, string email, DateTime ngaysinh, bool gioitinh)
        {
            sv.Ten = ten;
            sv.DiaChi = diachi;
            sv.Email = email;
            sv.NgaySinh = ngaysinh;
            sv.GioiTinh = gioitinh;
            int count = context.SaveChanges();
            if (count > 0)
            {
                LoadSV();
                MessageBox.Show("Cập nhật thông tin thành công!");
            }
            else
            {
                MessageBox.Show("Chưa có thông tin nào được thay đổi");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ten = txtTimkiem_Ten.Text;
            int gioitinh = -1;
            if(rdbTimkiem_Nam.Checked == true)
            {
                gioitinh = 1;
            }

            if(rdbTimkiem_Nu.Checked == true)
            {
                gioitinh = 0;
            }          
            LoadSV(ten, gioitinh);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn có muốn xóa tất cả thông tin liên quan đến sinh viên này?", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            var sv = context.SinhViens.Find(txtMaSV.Text);
            var listD = context.Diems.Where(item => item.MaSv.Equals(txtMaSV.Text)).ToList();
            var listLH_SV = context.LopHocSinhViens.Where(item => item.MaSv.Equals(txtMaSV.Text)).ToList();
            if(sv!= null)
            {
                context.Diems.RemoveRange(listD);
                context.LopHocSinhViens.RemoveRange(listLH_SV);
                context.SinhViens.Remove(sv);
                int count = context.SaveChanges();
                if (count > 0)
                {
                    LoadSV();
                    ClearText();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Sinh viên không tồn tại");
            }
        }

        private void button_XemDiem_Click(object sender, EventArgs e)
        {
            masv_diem = txtMaSV.Text;
            var listD = context.Diems.Where(item => item.MaSv == txtMaSV.Text).ToList();
            if (listD.Count > 0)
            {
                FrmDiem frmDiem = new FrmDiem();
                frmDiem.Show();
            }
            else
            {
                MessageBox.Show("Chưa có điểm cho sinh viên này!");
            }
            
            
        }
    }
}
