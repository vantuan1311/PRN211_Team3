using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class DayHoc
    {
        public int MaDayHoc { get; set; }
        public int MaMonHoc { get; set; }
        public string MaLop { get; set; }
        public string MaGv { get; set; }

        public virtual GiangVien MaGvNavigation { get; set; }
        public virtual LopHoc MaLopNavigation { get; set; }
        public virtual MonHoc MaMonHocNavigation { get; set; }
    }
}
