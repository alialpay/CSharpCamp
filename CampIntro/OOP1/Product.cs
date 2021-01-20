using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //prop bir snippet tır
    class Product //Entity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }


    }
}
