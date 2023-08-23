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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picture_SV_Click(object sender, EventArgs e)
        {
            FrmSinhVien frmSinhVien = new FrmSinhVien();
            frmSinhVien.Show();
        }

        private void picture_Diem_Click(object sender, EventArgs e)
        {
            FrmDiem frmDiem = new FrmDiem();
            frmDiem.Show();
        }

        private void picture_LopHoc_Click(object sender, EventArgs e)
        {
            Lop frmLop = new Lop();
            frmLop.Show();
        }

        private void picture_MonHoc_Click(object sender, EventArgs e)
        {
            FrmMonHoc frmMonHoc = new FrmMonHoc();
            frmMonHoc.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
