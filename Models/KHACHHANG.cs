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
    
    public partial class KHACHHANG
    {
        public KHACHHANG()
        {
            this.CHAMSOCKHs = new HashSet<CHAMSOCKH>();
            this.DONHANGs = new HashSet<DONHANG>();
        }
    
        public string MAKH { get; set; }
        public string HOTEN { get; set; }
        public string EMAIL { get; set; }
        public string DIEN_THOAI { get; set; }
        public string DIACHI { get; set; }
        public string GIOITINH { get; set; }
        public string XEPLOAI { get; set; }
        public Nullable<int> TONGDONHANG { get; set; }
        public Nullable<System.DateTime> NGAYTAO { get; set; }
        public string PASSWORD { get; set; }
        public string TYPE { get; set; }
    
        public virtual ICollection<CHAMSOCKH> CHAMSOCKHs { get; set; }
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
    }
}