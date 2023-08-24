using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class LopHoc
    {
        public LopHoc()
        {
            DayHocs = new HashSet<DayHoc>();
            LopHocSinhViens = new HashSet<LopHocSinhVien>();
        }

        public string MaLop { get; set; }

        public virtual ICollection<DayHoc> DayHocs { get; set; }
        public virtual ICollection<LopHocSinhVien> LopHocSinhViens { get; set; }
    }
}
