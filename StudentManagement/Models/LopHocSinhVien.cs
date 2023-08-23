using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class LopHocSinhVien
    {
        public string MaLop { get; set; }
        public string MaSv { get; set; }

        public virtual LopHoc MaLopNavigation { get; set; }
        public virtual SinhVien MaSvNavigation { get; set; }
    }
}
