﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PhoneManagement
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PhoneStoreManagementEntities : DbContext
    {
        public PhoneStoreManagementEntities()
            : base("name=PhoneStoreManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TBL_ChiTietHDB> TBL_ChiTietHDB { get; set; }
        public virtual DbSet<TBL_ChiTietHoaDonNhap> TBL_ChiTietHoaDonNhap { get; set; }
        public virtual DbSet<TBL_HoaDonNhap> TBL_HoaDonNhap { get; set; }
        public virtual DbSet<TBL_KhachHang> TBL_KhachHang { get; set; }
        public virtual DbSet<TBL_Loai> TBL_Loai { get; set; }
        public virtual DbSet<TBL_ManHinh> TBL_ManHinh { get; set; }
        public virtual DbSet<TBL_NhaCungCap> TBL_NhaCungCap { get; set; }
        public virtual DbSet<TBL_NhanHieu> TBL_NhanHieu { get; set; }
        public virtual DbSet<TBL_NhanVien> TBL_NhanVien { get; set; }
        public virtual DbSet<TBL_Que> TBL_Que { get; set; }
        public virtual DbSet<TBL_SanPham> TBL_SanPham { get; set; }
    }
}