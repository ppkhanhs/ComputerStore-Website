﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace web_banmaytinh.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QL_CuaHangMayTinhEntities : DbContext
    {
        public QL_CuaHangMayTinhEntities()
            : base("name=QL_CuaHangMayTinhEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CHAMSOCKH> CHAMSOCKHs { get; set; }
        public DbSet<CHITIETDH> CHITIETDHs { get; set; }
        public DbSet<DANHMUCSP> DANHMUCSPs { get; set; }
        public DbSet<DONHANG> DONHANGs { get; set; }
        public DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public DbSet<KIEMTRASP> KIEMTRASPs { get; set; }
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<SANPHAM> SANPHAMs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
