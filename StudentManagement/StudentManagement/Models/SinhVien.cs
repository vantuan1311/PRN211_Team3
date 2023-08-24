using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class SinhVien
    {
        public SinhVien()
        {
            Diems = new HashSet<Diem>();
            LopHocSinhViens = new HashSet<LopHocSinhVien>();
        }

        public string MaSv { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public bool GioiTinh { get; set; }
        public string Email { get; set; }
        public DateTime NgaySinh { get; set; }
        //private string strgioiTinh;

        public string StrGioitinh
        {
            get
            {
                if (GioiTinh == true) { return "Nam"; }
                return "Nu";
            }
            //set { strgioiTinh = value; }
        }

        public virtual ICollection<Diem> Diems { get; set; }
        public virtual ICollection<LopHocSinhVien> LopHocSinhViens { get; set; }
    }
}
