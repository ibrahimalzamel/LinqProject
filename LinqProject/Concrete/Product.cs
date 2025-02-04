﻿using LinqProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqProject.Concrete
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal  UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

    }
}
