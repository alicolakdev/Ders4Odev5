using Ders4Odev5.Abstract;
using System;

namespace Ders4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member
            {
                Id = 1,
                Name="Ali",
                Surname="Çolak",
                TcNo="12345678912",
                DateOfBirth=1992
            };

            IMemberService memberService = new MemberManager();
            memberService.Add(member);

            ICampaignService campaignService = new CampaignManager();
            campaignService.Add(new Campaign { Id = 1, CampaignName = "Discount %10" });

            ISellService sellGames = new SellManager();
            sellGames.Sell(member);
        }
    }
}
