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
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;
using StudentManagement.Models;

namespace StudentManagement
{
    public partial class Lop_SV : Form
    {
        StudentManagementContext context = new StudentManagementContext();
        public string tem;
        public Lop_SV(string text)
        {
            InitializeComponent();
            tem = text;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSinhVien.Text == "" || txtSinhVien.Text == "")
            {
                MessageBox.Show("Vui Lòng Không Để Rỗng");
                return;
            }
            else if (txtSinhVien.Text == ""||txtSinhVien.TextLength > 6)
            {
                MessageBox.Show("Mã Sinh Viên Không Được Vượt 6 Ký Tự");
                return;
            }


            LopHocSinhVien lop_SV = new LopHocSinhVien { MaLop = txtLop_SV.Text, MaSv = txtSinhVien.Text };
            try
            {
                context.LopHocSinhViens.Add(lop_SV);
                int count = context.SaveChanges();
                if (count > 0)
                {
                    MessageBox.Show("Thêm Thành Công");
                    loadData();
                }
            }
            catch 
            {
                MessageBox.Show("Thêm Thất Bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if ( txtSinhVien.Text == "")
            {
                MessageBox.Show("Vui Lòng Không Để Rỗng");
                return;
            }
            
            if (MessageBox.Show(this, "Bạn có muốn xóa không?", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            var sinhVien = (from item in context.LopHocSinhViens
                            where item.MaSv == txtSinhVien.Text
                            select new { item.MaSv }).ToList();
            if (sinhVien.Count() > 0)
            {
                var lop_SV = context.LopHocSinhViens.SingleOrDefault(item => item.MaSv == txtSinhVien.Text);
                if (lop_SV != null)
                {
                    context.LopHocSinhViens.Remove(lop_SV);
                    int count = context.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        loadData();
                    }
                }
            } else
            {
                MessageBox.Show("Sinh Viên Không Tồn Tại");
            }

        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.ToString() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mã Sinh Viên Bạn Cần Tìm");
                return;
            }

            var lop_SV = (from item in context.LopHocSinhViens
                       where item.MaSv == txtTK.Text
                       select new { item.MaSv }).ToList();

            if (lop_SV.Count() > 0)
            {
                dgLop_SV.DataSource = lop_SV;
            }
            else
            {
                MessageBox.Show("Sinh Viên Không Tồn Tại");
                return;
            }

        }

        private void dgLop_SV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLop_SV.Text = dgLop_SV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtSinhVien.Text = dgLop_SV.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
        }

        private void Lop_SV_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var lop_SV = (from item in context.LopHocSinhViens
                          where item.MaLop == tem
                       select new { item.MaLop, item.MaSv }).ToList();
            dgLop_SV.DataSource = lop_SV;
            dgLop_SV.DataBindings.Clear();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Lop l = new Lop();
            l.Show();
            this.Hide();
        }
    }
}
