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
    
    public partial class CHAMSOCKH
    {
        public string MANV { get; set; }
        public string MAKH { get; set; }
        public string GHICHU { get; set; }
    
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
