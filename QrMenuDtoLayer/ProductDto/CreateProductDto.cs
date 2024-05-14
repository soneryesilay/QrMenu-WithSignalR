﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrMenu.DtoLayer.ProductDto
{
    public class CreateProductDto
    {
        public string productName { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string imageUrl { get; set; }
        public bool productStatus { get; set; }
        public int categoryID { get; set; }
    }
}
