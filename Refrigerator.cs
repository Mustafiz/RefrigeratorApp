using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppApp
{
    class Refrigerator
    {
        public double MaxRefrigeratorWeight { set; get; }
        public double ItemsNumber { set; get; }
        public double ItemPerWeight { set; get; }

        public double GetCurrentWeight()
        {
            return MaxRefrigeratorWeight - (ItemsNumber*ItemPerWeight);
        }

        public double GetRemainingWeight()
        {
            return MaxRefrigeratorWeight - GetCurrentWeight();
        }
    }
}
