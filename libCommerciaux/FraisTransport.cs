using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public class FraisTransport
    {
        private DateTime date;
        private int distance;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public FraisTransport(DateTime Date, int Distance)
        {
            this.date = Date;
            this.distance = Distance;
        }
    }
}
