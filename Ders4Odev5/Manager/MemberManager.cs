using Ders4Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4Odev5
{
    class MemberManager: IMemberService
    {
        public void Add(Member member)
        {
            Console.WriteLine("Yeni üye eklendi");
        }

        public void Update(Member member)
        {
            Console.WriteLine("Üye düzenlendi");
        }

        public void Delete(Member member)
        {
            Console.WriteLine("Üye kaydi silindi");
        }
    }
}
