using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo.Concrete
{
    public class SteamPlayerManager : BaseCustomerManager
    {
        private IPlayerCheckService _playerCheckService;

        public SteamPlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public override void Save(Player player)
        {
            if (_playerCheckService.CheckIfRealPerson(player))
            {
                base.Save(player);
            }
            else
            {
                Console.WriteLine("Kimlik bilgileri doğrulanamadı.");
            }

        }

        private void CheckIfRealPerson(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
