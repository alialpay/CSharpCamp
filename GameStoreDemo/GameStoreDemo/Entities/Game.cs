using GameStoreDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Entities
{
    public class Game :IEntity
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
