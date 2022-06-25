﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PBL3
{
    internal class BLLButtonBaoHanh
    {
        private static BLLButtonBaoHanh instance;
        public static BLLButtonBaoHanh Instance
        {
            get
            {
                if (instance == null)
                    instance = new BLLButtonBaoHanh();
                return instance;
            }
        }
        public List<ViewBaoHanh> SearchBaoHanh(string tuKhoa)
        {
            if (tuKhoa == "Nhập để tìm kiếm...")
                tuKhoa = "";
            string[] cacTuKhoa = tuKhoa.ToLower().Split(new string[] { ", ", "," }, System.StringSplitOptions.None);
            string temp = cacTuKhoa[0];
            List<ViewBaoHanh> list = Model.Instance.BaoHanhs.AsEnumerable().Where(bh => bh.MaBaoHanh.ToLower().Contains(temp) || bh.SoSeri.ToLower().Contains(temp) || bh.VatPham.HoaDon.KhachHang.TenKhachHang.ToLower().Contains(temp) || bh.VatPham.SanPham.TenSanPham.ToLower().Contains(temp) || bh.VatPham.HoaDon.KhachHang.SoDienThoai.Contains(temp) || bh.TrangThai.ToString().Contains(temp) || bh.GhiChu.ToLower().Contains(temp) || bh.ThoiGianTaoPhieuBaoHanh.ToString("dd/MM/yyyy h:m tt").Contains(temp))
                .Select(bh => new ViewBaoHanh { MaBaoHanh = bh.MaBaoHanh, SoSeri = bh.SoSeri, TenKhachHang = bh.VatPham.HoaDon.KhachHang.TenKhachHang, TenSanPham = bh.VatPham.SanPham.TenSanPham, SoDienThoai = bh.VatPham.HoaDon.KhachHang.SoDienThoai, TrangThai = bh.TrangThai, GhiChu = bh.GhiChu, ThoiGianTaoPhieuBaoHanh = bh.ThoiGianTaoPhieuBaoHanh })
                .ToList();
            foreach (string s in cacTuKhoa)
            {
                if (s != temp)
                {
                    list = list.Where(bh => bh.MaBaoHanh.ToLower().Contains(s) || bh.SoSeri.ToLower().Contains(s) || bh.SoDienThoai.ToLower().Contains(s) || bh.TenSanPham.ToLower().Contains(s) || bh.TenKhachHang.Contains(s) || bh.TrangThai.ToString().Contains(s) || bh.GhiChu.ToLower().Contains(s) || bh.ThoiGianTaoPhieuBaoHanh.ToString("dd/MM/yyyy h:m tt").Contains(s)).ToList();
                }
            }
            return list;
        }

        public List<ViewBaoHanh> SortBaoHanh(List<ViewBaoHanh> baoHanhs, string kieuSapXep)
        {
            if (kieuSapXep == "MaBaoHanh")
                return baoHanhs.OrderBy(bh => Convert.ToInt32(bh.MaBaoHanh.Substring(2))).ToList();
            return baoHanhs.OrderBy(bh => bh.GetType().GetProperty(kieuSapXep).GetValue(bh, null)).ToList();
        }

        public List<ViewBaoHanh> GetBaoHanhs(string kieuSapXep, string tuKhoa)
        {
            return SortBaoHanh(SearchBaoHanh(tuKhoa), kieuSapXep);
        }

        public int DaysExceedWarrantyPeriod(string soSeri)
        {
            if ((DateTime.Now - Model.Instance.VatPhams.FirstOrDefault(vp => vp.SoSeri == soSeri).HoaDon.ThoiGianGiaoDich).Days > 365 * Convert.ToInt32(Model.Instance.VatPhams.FirstOrDefault(vp => vp.SoSeri == soSeri).SanPham.ThoiGianBaoHanh.Substring(0, 1)))
            {
                return (DateTime.Now - Model.Instance.VatPhams.FirstOrDefault(vp => vp.SoSeri == soSeri).HoaDon.ThoiGianGiaoDich).Days - 365 * Convert.ToInt32(Model.Instance.VatPhams.FirstOrDefault(vp => vp.SoSeri == soSeri).SanPham.ThoiGianBaoHanh.Substring(0, 1));
            }
            else
            {
                return 0;
            }
        }
    }
}
