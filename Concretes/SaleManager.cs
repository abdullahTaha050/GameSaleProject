using GameSaleProject.Business;
using GameSaleProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject
{
    class SaleManager : ISaleService
    {
        public void Sell(Gamer gamer, Item item)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncuya " + item.ItemName + " satışı yapıldı.");
        }
    }
}
