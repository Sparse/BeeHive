using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive
{
    class Bee
    {
        public virtual int ShiftsLeft { get { return 0; } }
        private float mWeight;

        public Bee(float pWeight)
        {
            mWeight = pWeight;
        }

        public virtual double GetHoneyConsumption()
        {
            double honeyConsumption;
            if (ShiftsLeft == 0) honeyConsumption = 7.5;
            else honeyConsumption = 9 + ShiftsLeft;

            if (mWeight > 150) honeyConsumption *= 1.35;

            return honeyConsumption;
        }
    }
}
