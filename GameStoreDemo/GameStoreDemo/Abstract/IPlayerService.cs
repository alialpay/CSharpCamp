using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    public interface IPlayerService
    {
        public void Add(Player player);
        public void Delete(Player player);
        public void Update(Player player);
    }
}
