using System;
using System.Collections.Generic;

namespace TinhTienSinhHoat.Models
{
    public partial class LoaiChiTieu
    {
        public LoaiChiTieu()
        {
            ChiTieus = new HashSet<ChiTieu>();
        }

        public int LoaiChiTieuId { get; set; }
        public string? TenChiTieu { get; set; }
        public DateTime? Date { get; set; }

        public virtual ICollection<ChiTieu> ChiTieus { get; set; }
    }
}
