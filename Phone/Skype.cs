using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Skype:ICaller
    {
        public int Call(int time)
        {
            return 5 * time;
        }
    }
}
