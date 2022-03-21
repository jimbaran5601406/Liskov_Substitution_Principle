using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L030.Objects
{
    public sealed class Gold : Member
    {
        public override int GetPoint(int price)
        {
            return Convert.ToInt32(price * 0.2f);
        }
    }
}
