using GameSaleProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Business
{
    interface ISaleService
    {
        void Sell(Gamer gamer, Item item);
    }
}
