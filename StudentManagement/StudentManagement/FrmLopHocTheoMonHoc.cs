using StudentManagement.Models;
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
    public partial class FrmLopHocTheoMonHoc : Form
    {
        int mamon = 0;
        StudentManagementContext contex = new StudentManagementContext();
        public FrmLopHocTheoMonHoc()
        {
            InitializeComponent();
        }
        public FrmLopHocTheoMonHoc(int mamonhoc)
        {
            InitializeComponent();
            mamon = mamonhoc;
        }

        private void FrmLopHocTheoMonHoc_Load(object sender, EventArgs e)
        {
            txtMaMonHoc.ReadOnly = true;
            comboBox1.SelectedIndex = 0;
            LoadData();
        }
        private void LoadData()
        {
            var lophoctheomonhoc = (from item in contex.DayHocs where item.MaMonHoc == mamon
                          select new { item.MaDayHoc,item.MaMonHoc,item.MaLop,item.MaGv })
                            .ToList();
            //cho du lieu len form
            dgvLopHocTheoMonHoc.DataSource = lophoctheomonhoc;
            // lay du lieu len form
            txtMaDayHoc.DataBindings.Clear();
            txtMaDayHoc.DataBindings.Add("Text", lophoctheomonhoc, "MaDayHoc");

            txtMaMonHoc.DataBindings.Clear();
            txtMaMonHoc.DataBindings.Add("Text", lophoctheomonhoc, "MaMonHoc");

            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", lophoctheomonhoc, "MaLop");

            txtMaGv.DataBindings.Clear();
            txtMaGv.DataBindings.Add("Text", lophoctheomonhoc, "MaGV");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (txtMaDayHoc.Text.Equals("") || txtMaMonHoc.Text.Equals("") || txtMaLop.Text.Equals("") || txtMaGv.Text.Equals(""))
            {
                MessageBox.Show("Loi rong");
                return;
            }
          
            for (int i = 0; i < dgvLopHocTheoMonHoc.Rows.Count; i++)
            {
                if (dgvLopHocTheoMonHoc.Rows[i].Cells[0].FormattedValue.ToString() == txtMaDayHoc.Text)
                {
                    check = true;
                }

            }
            var listLopHoc = from item in contex.LopHocs
                             where item.MaLop == txtMaLop.Text
                             select item;
            if (listLopHoc.Count() < 1)
            {
                MessageBox.Show("Ma lop hoc khong ton tai trong he thong");
                return;
            }
            var listGiangvien = from item in contex.GiangViens
                                where item.MaGv == txtMaGv.Text
                                select item;
            if (listGiangvien.Count() < 1)
            {
                MessageBox.Show("Ma Giang Vien khong ton tai trong he thong");
                return;
            }
           
            if (check == true)
            {
               

                    var dayhoc = contex.DayHocs.SingleOrDefault(item => item.MaDayHoc == int.Parse(txtMaDayHoc.Text));
                    if (dayhoc != null)
                    {
                        dayhoc.MaMonHoc = int.Parse(txtMaMonHoc.Text);
                        dayhoc.MaLop = txtMaLop.Text;
                        dayhoc.MaGv = txtMaGv.Text;
                        int count = contex.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Sua Thanh Cong");
                            LoadData();
                        }
                    }
                
            }
            else
            {
                MessageBox.Show("Ma day hoc khong ton tai chuong trinh day hoc");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (txtMaDayHoc.Text.Equals(""))
            {
                MessageBox.Show("Khong de rong Ma Day Hoc ");
                return;
            }
            for (int i = 0; i < dgvLopHocTheoMonHoc.Rows.Count; i++)
            {
                if (dgvLopHocTheoMonHoc.Rows[i].Cells[0].FormattedValue.ToString() == txtMaDayHoc.Text)
                {
                    check = true;
                }

            }
            if(check == true)
            {
                var listDayHoc = contex.DayHocs.SingleOrDefault(item => item.MaDayHoc == int.Parse(txtMaDayHoc.Text));
                if (listDayHoc != null)
                {
                    contex.DayHocs.Remove(listDayHoc);
                    int count = contex.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Xoa thanh cong");
                        LoadData();
                    }
                }
            }
            else
            {
                MessageBox.Show("Khong ton tai chuong trinh hoc");
            }
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            bool check = true;
            var listLopHoc = from item in contex.LopHocs
                             where item.MaLop == txtMaLop.Text
                             select item;
            if (listLopHoc.Count() < 1)
            {
                MessageBox.Show("Ma lop hoc khong ton tai trong he thong");
                return;
            }
            var listGiangvien = from item in contex.GiangViens
                                where item.MaGv == txtMaGv.Text
                                select item;
            if (listGiangvien.Count() < 1)
            {
                MessageBox.Show("Ma Giang Vien khong ton tai trong he thong");
                return;
            }
            for (int i = 0; i < dgvLopHocTheoMonHoc.Rows.Count; i++)
            {
                if (dgvLopHocTheoMonHoc.Rows[i].Cells[0].FormattedValue.ToString() == txtMaDayHoc.Text)
                {
                    check = false;
                }

            }
            if(check == true)
            {
                DayHoc dayhoc = new DayHoc { MaDayHoc = int.Parse(txtMaDayHoc.Text), MaMonHoc = int.Parse(txtMaMonHoc.Text), MaLop = txtMaLop.Text, MaGv = txtMaGv.Text };
               
                    contex.DayHocs.Add(dayhoc);
                    int count = contex.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Them lop hoc theo mon hoc " + txtMaMonHoc.Text + " thanh cong");
                        LoadData();

                    }               
            }
            else
            {
                MessageBox.Show("Ma day hoc da ton tai trong he thong");
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToLower().Equals("ma day hoc"))
            {

                var dayhocs = (from item in contex.DayHocs
                               where item.MaDayHoc == int.Parse(txtMaDayHoc.Text) && item.MaMonHoc == int.Parse(txtMaMonHoc.Text)
                               select new { item.MaDayHoc, item.MaMonHoc, item.MaLop, item.MaGv }).ToList();
                //cho du lieu len form
                if(dayhocs.Count <= 0)
                {
                    MessageBox.Show("Ma day hoc khong ton tai");
                }
                else
                {
                    dgvLopHocTheoMonHoc.DataSource = dayhocs;
                }
               


            }
            
            else if (comboBox1.Text.ToLower().Equals("ma lop"))
            {
                var dayhocs = (from item in contex.DayHocs
                              where item.MaLop == (txtMaLop.Text) && item.MaMonHoc == int.Parse(txtMaMonHoc.Text)
                              select new { item.MaDayHoc, item.MaMonHoc, item.MaLop, item.MaGv}).ToList();
                //cho du lieu len form
                if (dayhocs.Count <= 0)
                {
                    MessageBox.Show("Ma day hoc khong ton tai");
                }
                else
                {
                    dgvLopHocTheoMonHoc.DataSource = dayhocs;
                }

            }
            else if(comboBox1.Text.ToLower().Equals("ma giang vien"))
            {
                var dayhocs = (from item in contex.DayHocs
                               where item.MaGv == (txtMaGv.Text) && item.MaMonHoc == int.Parse(txtMaMonHoc.Text)
                               select new { item.MaDayHoc, item.MaMonHoc, item.MaLop, item.MaGv }).ToList();
                //cho du lieu len form
                if (dayhocs.Count <= 0)
                {
                    MessageBox.Show("Ma day hoc khong ton tai");
                }
                else
                {
                    dgvLopHocTheoMonHoc.DataSource = dayhocs;
                }
            }
        }

        private void txtMaDayHoc_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMaDayHoc.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui long nhap so");
                txtMaDayHoc.Text = txtMaDayHoc.Text.Remove(txtMaDayHoc.Text.Length - 1);
            }
        }

        private void txtMaMonHoc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
