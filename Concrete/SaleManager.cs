using GameBackend.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend.Concrete
{
    public class SaleManager : ICampaingSale
    {
        public void CampaingSale(Campaign campaign)
        {
            Console.WriteLine(campaign.Name + " kampanya satışı.");
        }

        public void Sale(Game game)
        {
            Console.WriteLine(game.Name + " oyunu satıldı.");
        }
    }
}
