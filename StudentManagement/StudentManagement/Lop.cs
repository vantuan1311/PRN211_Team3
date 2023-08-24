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
    public partial class Lop : Form
    {
        StudentManagementContext context = new StudentManagementContext();
        
        public Lop()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtLop.Text == "")
            {
                MessageBox.Show("Chuỗi Rỗng");
                return;
            }
            else if (txtLop.TextLength > 6)
            {
                MessageBox.Show("Mã Lớp Học Không Được Vượt 6 Ký Tự");
                return;
            }
            LopHoc lop = new LopHoc { MaLop = txtLop.Text};
            try
            {
                context.LopHocs.Add(lop);
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

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            if (txtLop.Text == "")
            {
                MessageBox.Show("Chuỗi Rỗng");
                return;
            }

            var lop = (from item in context.LopHocs
                       where item.MaLop == txtLop.Text
                       select new { item.MaLop }).ToList();
            if (lop.Count() > 0)
            {
                var lop_SinhVien = (from item in context.LopHocSinhViens
                                    where item.MaLop == txtLop.Text
                                    select new { item.MaLop, item.MaSv }).ToList();
                if (lop_SinhVien.Count() > 0)
                {
                    Lop_SV l = new Lop_SV(txtLop.Text);
                    l.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lớp Chưa Có Sinh Viên");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Lớp Không tồn Tại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtLop.Text == "")
            {
                MessageBox.Show("Vui Lòng Không Để Rỗng");
                return;
            }
            if (MessageBox.Show(this, "Bạn có muốn xóa không?", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            var LopHoc = (from item in context.LopHocs
                          where item.MaLop == txtLop.Text
                          select new { item.MaLop }).ToList();

            var Lop_SinhVien = (from item in context.LopHocSinhViens
                                where item.MaLop == txtLop.Text
                                select new { item.MaLop }).ToList();
            if (Lop_SinhVien.Count() > 0)
            {
                MessageBox.Show("Lớp Đang Tồn Tại Sinh Viên");
                return;
            }

            if (LopHoc.Count() > 0)
            {

                var lop = context.LopHocs.SingleOrDefault(item => item.MaLop == txtLop.Text);
                if (lop != null)
                {
                    context.LopHocs.Remove(lop);
                    int count = context.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Xóa Thành Công");
                        loadData();
                    }
                }
                else
                {
                    MessageBox.Show("Xóa Thất Bại");
                }
            }
            else
            {
                MessageBox.Show("Lớp Không Tồn Tại");
            }


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.ToString() == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mã Lớp Bạn Cần Tìm");
                return;
            }

            var lop = (from item in context.LopHocs
                       where item.MaLop == txtTK.Text
                       select new { item.MaLop }).ToList();

            if (lop.Count() > 0)
            {
                dgLop.DataSource = lop;
            } else
            {
                MessageBox.Show("Lớp Không Tồn Tại");
                return;
            }
                    
        }


        private void dgLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLop.Text = dgLop.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var lop = (from item in context.LopHocs
                       select new { item.MaLop }).ToList();
            dgLop.DataSource = lop;
            txtLop.DataBindings.Clear();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            Close();
        }

    }
}
