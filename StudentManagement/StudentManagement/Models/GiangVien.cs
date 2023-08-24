using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class GiangVien
    {
        public GiangVien()
        {
            DayHocs = new HashSet<DayHoc>();
        }

        public string MaGv { get; set; }
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }

        public virtual ICollection<DayHoc> DayHocs { get; set; }
    }
}
