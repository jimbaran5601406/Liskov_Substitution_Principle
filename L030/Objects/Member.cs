using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L030.Objects
{
    public class Member
    {
        public enum MemberKind
        {
            Silver,
            Gold,
        }

        public virtual int GetId()
        {
            return 999;
        }

        public virtual int GetPoint(int price)
        {
            return 0;
        }

        public static Member Create(MemberKind kind)
        {
            if(MemberKind.Gold == kind)
            {
                return new Gold();
            }

            return new Silver();
        }
    }
}
