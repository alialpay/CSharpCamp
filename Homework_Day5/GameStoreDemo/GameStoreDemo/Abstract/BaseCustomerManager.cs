using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService, IGameService
    {

        public void Add(IEntity player)
        {
            throw new NotImplementedException();
        }

        public void Add(Game game)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEntity player)
        {
            throw new NotImplementedException();
        }

        public void Delete(Game game)
        {
            throw new NotImplementedException();
        }

        public void GetAllGames()
        {
            throw new NotImplementedException();
        }

        public void GetGame(Game game)
        {
            throw new NotImplementedException();
        }

        public virtual void Save(Player player)    // virtual anahtar kelimesi bu metodun ezilebilmesini sağlar
        {
            Console.WriteLine("Kullanıcı sisteme kaydedildi : " + player.FirstName);
        }

        public void Save(IEntity player)
        {
            throw new NotImplementedException();
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun başarıyla güncellendi.");
        }
    }
}