using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Entities
{
    class Sale
    {
        public DateTime SaleTime { get; set; }
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public string GameName { get; set; }
        public string BuyerName { get; set; }

    }
}
