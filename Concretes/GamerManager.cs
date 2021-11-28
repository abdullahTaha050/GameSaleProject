using GameSaleProject.Business;
using GameSaleProject.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Concretes
{
    class GamerManager : IGamerService
    {
        EDevletCheckManager eDevletCheckManager = new EDevletCheckManager();

        private bool _eDevletCheckRespone;
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" adlı oyuncu silindi.");
        }
        
        public void Register(Gamer gamer)
        {
            _eDevletCheckRespone = eDevletCheckManager.Check(gamer);

            if(_eDevletCheckRespone)
            {
                Console.WriteLine(gamer.FirstName + " adlı oyuncu kaydedildi.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu güncellendi.");
        }
    }
}
