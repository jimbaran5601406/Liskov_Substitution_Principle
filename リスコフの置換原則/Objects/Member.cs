using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace リスコフの置換原則.Objects
{
    public abstract class Member
    {
        public enum MemberKind
        {
            Silver,
            Gold,
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
