using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhTienSinhHoat.Models;

namespace TinhTienSinhHoat.Logic
{
    public class QLChiTieu
    {
        public List<ChiTieu> getAll()
        {
            using(QuanLyChiTieuContext context = new QuanLyChiTieuContext())
            {
                return context.ChiTieus.Include(x => x.LoaiChiTieu).OrderBy(x=> x.MucDichChiTieu).ToList();
            }
        }
        public void Insert(ChiTieu chiTieu)
        {
            using (QuanLyChiTieuContext context = new QuanLyChiTieuContext())
            {
                context.ChiTieus.Add(chiTieu);
                if (context.SaveChanges() > 0)
                {
                    MessageBox.Show("Thêm Thanh Công");
                }
            }
        }
        public void DeleteByID(int id)
        {
            using (QuanLyChiTieuContext context = new QuanLyChiTieuContext())
            {
                ChiTieu chiTieu = context.ChiTieus.FirstOrDefault(x => x.Id == id);
                if(chiTieu != null)
                {
                    context.ChiTieus.Remove(chiTieu);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Xóa Thanh Công");
                    }
                }
                
            }
        }
        public ChiTieu getById(int id)
        {

            using (QuanLyChiTieuContext context = new QuanLyChiTieuContext())
            { 
               return context.ChiTieus.Include(x=> x.LoaiChiTieu).FirstOrDefault(x => x.Id == id); 
            }
        }
        public void Edit(ChiTieu chiTieu)
        {
            using (QuanLyChiTieuContext context = new QuanLyChiTieuContext())
            {
                ChiTieu chiTieu1 = context.ChiTieus.FirstOrDefault(x => x.Id == chiTieu.Id);
                if (chiTieu1 != null)
                {
                    chiTieu1.MucDichChiTieu = chiTieu.MucDichChiTieu;
                    chiTieu1.GiaTien = chiTieu.GiaTien;
                    chiTieu1.LoaiChiTieuId = chiTieu.LoaiChiTieuId;
                    chiTieu1.ThoiGian = chiTieu.ThoiGian;
                    context.ChiTieus.Update(chiTieu1);
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Update Thanh Công");
                    }
                }
            }
        }
    }
}
