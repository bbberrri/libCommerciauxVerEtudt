using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public class RepasMidi
    {
        private DateTime date;
        private double facture;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public double Facture
        {
            get { return facture; }
            set { facture = value; }
        }

        public RepasMidi(DateTime Date, double Facture)
        {
            this.date = Date;
            this.facture = Facture;
        }
    }
}
