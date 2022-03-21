using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L040.Objects
{
    public abstract class Member
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

        public abstract int GetPoint(int price);

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
