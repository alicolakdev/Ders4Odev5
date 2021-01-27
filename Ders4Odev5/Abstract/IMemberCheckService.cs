using System;
using System.Collections.Generic;
using System.Text;

namespace Ders4Odev5.Abstract
{
    public interface IMemberCheckService
    {
        bool CheckIfRealPerson(Member member);
    }
}
