﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProductList
    {
        public IList<Product> Products { get; set; }=new List<Product>();
    }
}
