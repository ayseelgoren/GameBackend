using GameBackend.Concrete;
using System;

namespace GameBackend
{
    class Program
    {
        static void Main(string[] args)
        {
            //Oyuncu kayıt ve doğrulama
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                Name = "ayse",
                LastName = "elgoren",
                NationalityNumber = "12345678911",
                YearOfBirth = 1997
            };
            
            BaseManager baseManager = new GamerManager(new EdevletValidate());
            baseManager.Create(gamer1);

            //Kampanya kayıt,silme,güncelleme

            Campaign campaign = new Campaign 
            { 
                Id = 2, 
                Description = "Yeni yıla özele ", 
                Name = "Yeni yıl", 
                Price = 52 
            };

            BaseManager baseManager2 = new CampaignManager();
            baseManager2.Create(campaign);
            baseManager2.Delete(campaign);
            baseManager2.Update(campaign);


            //Oyun Satışı

            Game game = new Game
            {
                Id = 3,
                Name = "Snake",
                Publisher = "Yayımcı olarak bilinmiyor",
                UnitPrice = 800
            };
            SaleManager saleManager = new SaleManager();
            saleManager.Sale(game);

            //Satışlarda kampanya entegrasyonu

            saleManager.CampaingSale(campaign);

        }
    }
}
