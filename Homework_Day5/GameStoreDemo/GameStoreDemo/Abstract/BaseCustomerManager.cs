using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService, IGameService
    {
        public void Add(Player player)
        {
            Console.WriteLine("Oyuncu listeye eklendi.");
        }

        public void Add(Game game)
        {
            Console.WriteLine("Oyun satışı gerçekleşti : " + game);
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Kullanıcı bilgileri silindi.");
        }

        public virtual void Save(Player player)    // virtual anahtar kelimesi bu metodun ezilebilmesini sağlar
        {
            Console.WriteLine("Kullanıcı sisteme kaydedildi : " + player.FirstName );
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun başarıyla güncellendi.");
        }
    }
}