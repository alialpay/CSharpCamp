using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(IEntity player);
        void Add(IEntity player);
        void Delete(IEntity player);

    }
}
