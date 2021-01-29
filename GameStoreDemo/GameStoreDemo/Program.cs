

using GameStoreDemo.Abstract;
using GameStoreDemo.Adapters;
using GameStoreDemo.Concrete;
using GameStoreDemo.Entities;
using System;

namespace GameStoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstract.BaseCustomerManager playerManager = new SteamPlayerManager(new MernisServiceAdapter());
            playerManager.Save(new Player { DateOfBirth = 1996, FirstName = "MUHAMMED ALİ", LastName = "ALPAY", Id = 123, NationalityId = 13324058152 });
            Console.ReadLine();

            IEntity ageOf = new Game() { Name = "Age Of Empires", Price = 70 };

        }
    }

}
