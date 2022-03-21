using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L040.Objects
{
    public sealed class Platinum : Member
    {
        public override int GetPoint(int price)
        {
            return Convert.ToInt32(price * 0.3f);
        }

        public int GetDoublePoint(int price)
        {
            return Convert.ToInt32(price * 0.6f);
        }
    }
}
