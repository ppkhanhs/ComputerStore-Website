using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_banmaytinh.Models
{
    public class Invoice
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
    }

}