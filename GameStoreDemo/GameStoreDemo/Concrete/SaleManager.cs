using System;
using System.Collections.Generic;
using System.Text;
using GameStoreDemo.Abstract;
using GameStoreDemo.Entities;

namespace Day5Homework5.Concrete
{
    class SaleManager : ISaleService
    {
        List<Sale> SaleList = new List<Sale>();
        public int counter = 100000;
        public void Sale(Player player, Game game)
        {
            player.HaveGame.Add(game.Name);
            player.Balance = player.Balance - game.Price;
            Sale tempSale = new Sale();
            tempSale.Id = counter + 1;
            tempSale.SaleTime = DateTime.Now;
            tempSale.BuyerName = player.FirstName + " " + player.LastName;
            tempSale.GameName = game.Name;
            counter = counter + 1;
            SaleList.Add(tempSale);
        }
        public void SaleWithDiscount(Player player, Game game, Campaign campaign)
        {
            player.HaveGame.Add(game.Name);
            player.Balance = player.Balance - (game.Price - (game.Price * (campaign.Discount / 100)));
            Sale tempSale = new Sale();
            tempSale.Id = counter + 1;
            tempSale.SaleTime = DateTime.Now;
            tempSale.BuyerName = player.FirstName + " " + player.LastName;
            tempSale.GameName = game.Name;
            counter = counter + 1;
            SaleList.Add(tempSale);
        }

        public void GetSales()
        {
            foreach (var sale in SaleList)
            {
                Console.WriteLine("Sale ID: " + sale.Id);
                Console.WriteLine("Sale Date: " + sale.SaleTime);
                Console.WriteLine("Buyer Name: " + sale.BuyerName);
                Console.WriteLine("Game Name: " + sale.GameName);
                Console.WriteLine("----------------------------");
            }
        }
    }
}