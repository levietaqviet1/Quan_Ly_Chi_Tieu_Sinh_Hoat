using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhTienSinhHoat.Models;

namespace TinhTienSinhHoat.Logic
{
    public class QLLoaiChiTieu
    {
        public List<LoaiChiTieu> getAll()
        {
            using(QuanLyChiTieuContext context = new QuanLyChiTieuContext())
            {
                return context.LoaiChiTieus.ToList();
            }
        }
    }
}
