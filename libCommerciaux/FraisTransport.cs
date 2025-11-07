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
        private Commercial commercial;
        private int nbKm;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Commercial Commercial
        {
            get { return commercial; }
            set { commercial = value; }
        }
        public int NbKm
        {
            get { return nbKm; }
            set { nbKm = value; }
        }

        public FraisTransport(DateTime Date, Commercial Commercial, int NbKm)
        {
            this.date = Date;
            this.commercial = Commercial;
            this.nbKm = NbKm;
        }

        public double calculMontantARembourser()
        {

        }
    }
}
