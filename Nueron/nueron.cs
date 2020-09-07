using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nueron
{
    class nueron
    {
        public decimal x { get; private set; } = 0.5m;

      


        public int Train(decimal Y)
        {
            if(x+30==Y)
            {
                return 1;
            } else
            {
                x += 0.0001m;
                return -1;
            }
        }
    }
}
