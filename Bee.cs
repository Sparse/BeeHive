using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive
{
    class Bee
    {
        public virtual int ShiftsLeft { get; set; }

        public virtual void GetHoneyConsumption()
        {
            double honeyConsumption;
        }
    }
}
