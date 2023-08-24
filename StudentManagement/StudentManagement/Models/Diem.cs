using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Diem
    {
        public string MaSv { get; set; }
        public int MaMonHoc { get; set; }
        public double? Diem1 { get; set; }

        public virtual MonHoc MaMonHocNavigation { get; set; }
        public virtual SinhVien MaSvNavigation { get; set; }
    }
}
