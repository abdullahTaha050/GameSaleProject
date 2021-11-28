using GameSaleProject.Concretes;
using GameSaleProject.Entites;
using System;

namespace GameSaleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                TcNo = "11111111111",
                FirstName = "Abdullah Taha",
                LastName = "Aksakal",
                BirthDate = "16.10.2000"
            };

            GamerManager gamerManager = new GamerManager();
            gamerManager.Register(gamer1);

            Item item1 = new Item()
            {
                Id = 1,
                ItemName = "Backpack"
            };

            SaleManager saleManager = new SaleManager();
            saleManager.Sell(gamer1, item1);

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "Black Friday İndirimleri!"
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
        }
    }
}
