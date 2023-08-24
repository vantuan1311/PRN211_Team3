using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class FrmChiTietSinhVien : Form
    {
        public FrmChiTietSinhVien()
        {
            InitializeComponent();
        }

        private void FrmChiTietSinhVien_Load(object sender, EventArgs e)
        {
            txtTen.Text = FrmSinhVien.ten;
            txtEmail.Text = FrmSinhVien.email;
            txtMaSV.Text = FrmSinhVien.masv_diem;
            txtNgaySinh.Text = FrmSinhVien.ngaysinh.ToString();
            txtDiaChi.Text = FrmSinhVien.diachi;
            if (FrmSinhVien.gioitinh == true)
            {
                btnNam.Checked = true;
            }
            else
            {
                btnNu.Checked = false;
            }

        }
    }
}
