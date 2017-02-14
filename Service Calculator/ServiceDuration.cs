using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service_Calculator
{
    public struct ServiceDuration
    {
        public int Days;
        public int Months;
        public int Years;
        public override string ToString()
        {
            return Years + " سنة ، " + Months + " شهر ، " + Days + " يوم.";
        }

    }
}
