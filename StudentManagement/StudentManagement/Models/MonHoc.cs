using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class MonHoc
    {
        public MonHoc()
        {
            DayHocs = new HashSet<DayHoc>();
            Diems = new HashSet<Diem>();
        }

        public int MaMonHoc { get; set; }
        public string TenMonHoc { get; set; }

        public virtual ICollection<DayHoc> DayHocs { get; set; }
        public virtual ICollection<Diem> Diems { get; set; }
    }
}
