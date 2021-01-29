using GameStoreDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace GameStoreDemo.Abstract
{
    interface ICampaignService
    {
        public void ApplyDiscountToGame(Game game, Campaign campaign);
        public void Add(Campaign campaign);
        public void Delete(Campaign campaign);
        public void Update(Campaign campaign);
        public void GetCampaigns();

    }
}