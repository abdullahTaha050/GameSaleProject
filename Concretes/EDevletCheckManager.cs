using GameSaleProject.Business;
using GameSaleProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Concretes
{
    class EDevletCheckManager : IGamerCheckService
    {
        public bool Check(Gamer gamer)
        {
            if(gamer.TcNo == "11111111111" && gamer.FirstName == "Abdullah Taha" && gamer.LastName == "Aksakal" && gamer.BirthDate == "16.10.2000")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
