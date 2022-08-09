using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Directum.Classes
{
    public class Phone3G : Phone
    {
        public Phone3G(string number, List<User> userBook) : base(number, userBook)
        {
        }


        public new bool ConnectToBase(IBase targetBase)
        {
            if (targetBase.GetType() != typeof(Base3G))
                return false;
            if (targetBase.RegPhone(this))
            {
                CurrentBase = targetBase;
                return true;
            }
            return false;
        }
    }
}
