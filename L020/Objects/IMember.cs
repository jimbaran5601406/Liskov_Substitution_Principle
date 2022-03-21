using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L020.Objects
{
    //interface内にenumは記述できない
    public enum MemberKind
    {
        Silver,
        Gold,
    }
    public interface IMember
    {
        int GetPoint(int price);
    }

    public static class MemberFactory
    {
        public static IMember Create(MemberKind kind)
        {
            if(MemberKind.Gold == kind)
            {
                return new Gold();
            }

            return new Silver();
        }

    }
}
