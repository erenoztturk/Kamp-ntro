﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //sinppet
    class Product // entity 
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; } //urun fiyati
        public int UnitInStock { get; set; }

    }
}
