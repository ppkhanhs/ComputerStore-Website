//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class DONHANG
    {
        public DONHANG()
        {
            this.CHITIETDHs = new HashSet<CHITIETDH>();
        }
    
        public string MADH { get; set; }
        public System.DateTime NGAYTHUE { get; set; }
        public System.DateTime NGAYTRA { get; set; }
        public decimal TONGTIEN { get; set; }
        public string TRANGTHAI { get; set; }
        public decimal PHUTHU { get; set; }
        public Nullable<double> GIAMGIA { get; set; }
        public string MAKH { get; set; }
        public string MANV { get; set; }
    
        public virtual ICollection<CHITIETDH> CHITIETDHs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
