using Ders4Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4Odev5
{
    public class SellManager: ISellService
    {
        public void Sell(Member member)
        {
            Console.WriteLine(member.Name + " adlı kullanıcıya satış yapıldı");
        }

        public void SellWithCampaign(Member member, Campaign campaign)
        {
            Console.WriteLine(member.Name + " adlı kullanıcı " + campaign.CampaignName + "kampasıyla oyun satın aldı");
        }
    }
}
