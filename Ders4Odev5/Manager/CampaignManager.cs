using Ders4Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4Odev5
{
    class CampaignManager: ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Düzenlendi");
        }

        public void Delete(Campaign campaign )
        {
            Console.WriteLine("Kampanya Silindi");
        }
    }
}
