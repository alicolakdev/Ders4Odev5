using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4Odev5.Abstract
{
    public interface ISellService
    {
        void Sell(Member member);
        void SellWithCampaign(Member member, Campaign campaign);
    }
}
