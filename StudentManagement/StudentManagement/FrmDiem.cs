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
    public partial class FrmDiem : Form
    {
        public FrmDiem()
        {
            InitializeComponent();
        }
        StudentManagementContext context = new StudentManagementContext();
        private void dg_Diem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button_Xoa.Enabled = true;
            txtMaSV.Text = dg_Diem.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtMaMon.Text = dg_Diem.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtDiem.Text = dg_Diem.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
        }

        private void button_Them_Sua_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            string diem = txtDiem.Text;
            int mamonhoc = int.Parse(txtMaMon.SelectedValue.ToString());
            if (masv == "" || diem == "")
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
            else
            {
                var sv = context.SinhViens.Find(masv);
                var objDiem = context.Diems.Find(masv, mamonhoc);
                if (sv != null)
                {
                    if (objDiem != null)
                    {
                        updateDiem(objDiem, double.Parse(diem));
                    }
                    else
                    {
                        addDiem(masv, mamonhoc, double.Parse(diem));
                    }
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại!");
                }
            }
        }

        private void addDiem(string masv, int mamonhoc, double diem)
        {
            Diem objDiem = new Diem()
            {
                Diem1 = diem,
                MaMonHoc = mamonhoc,
                MaSv = masv,
            };
            context.Diems.Add(objDiem);
            int count = context.SaveChanges();
            if (count > 0)
            {
                LoadDiem();
                ClearText();
                MessageBox.Show("Thêm thành công!");
            }
        }

        private void updateDiem(Diem objDiem, double diem)
        {
            objDiem.Diem1 = diem;
            int count = context.SaveChanges();
            if (count > 0)
            {
                ClearText();
                LoadDiem();
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Chưa có thông tin nào được thay đổi!");
            }
        }

        private void ClearText()
        {
            txtDiem.Text = String.Empty;
            txtMaSV.Text = String.Empty;
        }

        private void FrmDiem_Load(object sender, EventArgs e)
        {
            txtTimkiem_MaSV.Text = FrmSinhVien.masv_diem;
            if(FrmSinhVien.masv_diem != "")
            {
                txtTimkiem_MaSV.ReadOnly = true;
                txtMaSV.ReadOnly = true;
            }
            LoadDiem(FrmSinhVien.masv_diem);
        }

        private void LoadDiem(string masv = null, string tenmonhoc = null, double diemduoi = 0, double diemtren = 10)
        {
            button_Xoa.Enabled = false;
            txtMaMon.DataSource = context.MonHocs.ToList();
            txtMaMon.DisplayMember = "TenMonHoc";
            txtMaMon.ValueMember = "MaMonHoc";
            context.MonHocs.ToList();
            context.SinhViens.ToList();
            List<Diem> list = context.Diems.Where(item => item.Diem1 >= diemduoi && item.Diem1 <= diemtren).ToList();
            if (tenmonhoc != null)
            {
                list = list.Where(item => item.MaMonHocNavigation.TenMonHoc.ToLower().Contains(tenmonhoc.ToLower())).ToList();
            }
            if (masv != null)
            {
                list = list.Where(item => item.MaSv.ToLower().Contains(masv.ToLower())).ToList();
            }
            dg_Diem.DataSource = list.Select(item => new { item.MaSv, item.MaSvNavigation.Ten, item.MaMonHocNavigation.TenMonHoc, Diem = item.Diem1 }).ToList();
        }

        private void button_Timkiem_Click(object sender, EventArgs e)
        {
            double diemduoi = 0;
            double diemtren = 10;
            if (txtTimkiem_DiemTu.Text != "")
            {
                diemduoi = double.Parse(txtTimkiem_DiemTu.Text);
            }
            if (txtTimkiem_DiemDen.Text != "")
            {
                diemtren = double.Parse(txtTimkiem_DiemDen.Text);
            }
            if (diemduoi >= 0 && diemtren <= 10 && diemduoi <= diemtren)
            {
                LoadDiem(txtTimkiem_MaSV.Text, txtTimkiem_MonHoc.Text, diemduoi, diemtren);
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ!");
            }
        }

        private void txtTimkiem_DiemTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Bạn có muốn xóa thông tin bản ghi này?", "Alert", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            string masv = txtMaSV.Text;
            int mamonhoc = int.Parse(txtMaMon.SelectedValue.ToString());
            var objDiem = context.Diems.Find(masv, mamonhoc);
            if (objDiem != null)
            {
                context.Diems.Remove(objDiem);
                int count = context.SaveChanges();
                if (count > 0)
                {
                    LoadDiem();
                    ClearText();
                    MessageBox.Show("Xóa thành công!");
                }
            }
            else
            {
                MessageBox.Show("Bản ghi không tồn tại!");
            }

        }

        private void FrmDiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmSinhVien.masv_diem = "";
        }
    }
}
