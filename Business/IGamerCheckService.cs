using GameSaleProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Business
{
    interface IGamerCheckService
    {
        bool Check(Gamer gamer);
    }
}
