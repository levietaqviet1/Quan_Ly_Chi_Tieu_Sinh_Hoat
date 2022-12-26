using System;
using System.Collections.Generic;

namespace TinhTienSinhHoat.Models
{
    public partial class ChiTieu
    {
        public int Id { get; set; }
        public string? MucDichChiTieu { get; set; }
        public int? GiaTien { get; set; }
        public int? LoaiChiTieuId { get; set; }
        public DateTime? ThoiGian { get; set; }

        public virtual LoaiChiTieu? LoaiChiTieu { get; set; }
    }
}
