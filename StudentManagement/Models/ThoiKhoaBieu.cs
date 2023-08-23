using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class ThoiKhoaBieu
    {
        public DateTime Ngay { get; set; }
        public int MaDayHoc { get; set; }
        public int Slot { get; set; }

        public virtual DayHoc MaDayHocNavigation { get; set; }
    }
}
