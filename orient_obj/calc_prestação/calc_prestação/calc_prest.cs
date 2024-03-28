using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_prestação
{
    class calc_prest
    {
        public double prest(double x, double y, double z){
            return x + (x * (y / 100) * z);
            }
    }
}
