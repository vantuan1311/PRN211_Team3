using Microsoft.EntityFrameworkCore;
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
    public partial class FrmMonHoc : Form
    {
        StudentManagementContext contex = new StudentManagementContext();
        public FrmMonHoc()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTenmonhoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMamonhoc_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMamonhoc.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui long nhap so");
                txtMamonhoc.Text = txtMamonhoc.Text.Remove(txtMamonhoc.Text.Length - 1);
            }
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
           
        }
        private void LoadData()
        {
            var monhoc = (from item in contex.MonHocs
                              select new { item.MaMonHoc, item.TenMonHoc })
                            .ToList();
            //cho du lieu len form
            dgvMonHoc.DataSource = monhoc;
            // lay du lieu len form
            txtMamonhoc.DataBindings.Clear();
            txtMamonhoc.DataBindings.Add("Text", monhoc, "MaMonHoc");

            txtTenmonhoc.DataBindings.Clear();
            txtTenmonhoc.DataBindings.Add("Text", monhoc, "TenMonHoc");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txtTenmonhoc.Text.Equals("") && txtMamonhoc.Text.Equals(""))
            {
                MessageBox.Show("Loi ten mon hoc va ma mon hoc rong");
                return;
            }
            for (int i = 0; i < dgvMonHoc.Rows.Count; i++)
            {
                if (dgvMonHoc.Rows[i].Cells[0].FormattedValue.ToString() == txtMamonhoc.Text)
                {
                    check = false;
                }

            }
            if (txtTenmonhoc.TextLength > 20)
            {
                MessageBox.Show("Ten mon hoc khong duoc qua 20 ky tu");
            }
            if (check == true)
            {
                MonHoc monhoc = new MonHoc { MaMonHoc = int.Parse(txtMamonhoc.Text), TenMonHoc = txtTenmonhoc.Text };
                try
                {
                    contex.MonHocs.Add(monhoc);
                    int count = contex.SaveChanges();
                    if (count > 0)
                    {
                        MessageBox.Show("Them mon hoc thanh cong");
                        LoadData();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Loi them mon hoc" + ex);
                }
            }
            else
            {
                MessageBox.Show("Da ton tai mon hoc co ma " + txtMamonhoc.Text);
            }
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (txtTenmonhoc.Text.Equals("") && txtMamonhoc.Text.Equals(""))
            {
                MessageBox.Show("Loi ten mon hoc va ma mon hoc rong ");
                return;
            }
            if (txtTenmonhoc.TextLength > 20)
            {
                MessageBox.Show("Ten mon hoc khong duoc qua 20 ky tu");
            }
            for (int i = 0; i < dgvMonHoc.Rows.Count; i++)
            {
                if (dgvMonHoc.Rows[i].Cells[0].FormattedValue.ToString() == txtMamonhoc.Text)
                {
                    check = true;
                }

            }
            if(check == true)
            {
                

                    var monhoc = contex.MonHocs.SingleOrDefault(item => item.MaMonHoc == int.Parse(txtMamonhoc.Text));
                    if (monhoc != null)
                    {
                        monhoc.TenMonHoc = txtTenmonhoc.Text;
                        int count = contex.SaveChanges();
                        if (count > 0)
                        {
                            MessageBox.Show("Cap nhat thanh cong");
                            LoadData();
                        }
                    }
                
              
            }
            else
            {
                MessageBox.Show("Khong ton tai mon hoc");
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (txtTenmonhoc.Text.Equals(""))
            {
                MessageBox.Show("Loi ten mon hoc rong ");
                return;
            }
            var listDayHoc = from item in contex.DayHocs
                              where item.MaMonHoc == int.Parse(txtMamonhoc.Text)
                              select item;
            if (listDayHoc.Count() > 0)
            {
                MessageBox.Show(txtMamonhoc.Text + " dang ton tai trong chuong trinh day hoc");
                return;
            }
            for (int i = 0; i < dgvMonHoc.Rows.Count; i++)
            {
                if (dgvMonHoc.Rows[i].Cells[0].FormattedValue.ToString() == txtMamonhoc.Text)
                {
                    check = true;
                }

            }
            if(check == true)
            {
                var monhoc = contex.MonHocs.SingleOrDefault(item => item.MaMonHoc == int.Parse(txtMamonhoc.Text));
                if (monhoc != null)
                {
                    contex.MonHocs.Remove(monhoc);
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
                MessageBox.Show("Khong ton tai ma mon hoc");
            }
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txtTenmonhoc.Text.Equals(""))
            {
                MessageBox.Show("Loi ten mon hoc rong ");
                return;
            }
            
            var monhoc = (from item in contex.MonHocs where item.MaMonHoc == int.Parse(txtMamonhoc.Text)
                          select new { item.MaMonHoc, item.TenMonHoc })
                          .ToList();
            //cho du lieu len form
            dgvMonHoc.DataSource = monhoc;
           
           
        }

        private void btnViewClass_Click(object sender, EventArgs e)
        {
          
            if (txtTenmonhoc.Text.Equals(""))
            {
                MessageBox.Show("Loi ma mon hoc rong ");
                return;
            }
            FrmLopHocTheoMonHoc f = new FrmLopHocTheoMonHoc(int.Parse(txtMamonhoc.Text));
            f.Show();
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            if (txtTenmonhoc.Text.Equals(""))
            {
                MessageBox.Show("Loi ten mon hoc rong ");
                return;
            }
            var monhoc = (from item in contex.MonHocs
                          where EF.Functions.Like(item.TenMonHoc, "%" + txtTenmonhoc.Text + "%")   
                          select new { item.MaMonHoc, item.TenMonHoc })
                         .ToList();
            //cho du lieu len form
            dgvMonHoc.DataSource = monhoc;
        }
    }
}
