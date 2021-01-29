using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    public interface IGameService
    {
        void Add(IEntity game);
        void Update(IEntity game);
    }
}
