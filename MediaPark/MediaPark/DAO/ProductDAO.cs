using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MediaPark.DAO
{
    public class ProductDAO
    {
        public int ProductId { get; set; }
        public string SL { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductPrice { get; set; }
        public string ProductStock { get; set; }
        public string ProductCategory { get; set; }
        public string ProductWeight { get; set; }

    }
}