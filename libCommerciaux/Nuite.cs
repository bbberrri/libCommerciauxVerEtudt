using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public class Nuite : NoteFrais
    {
        private double montantFacture;
        private char region;

        public double MontantFacture
        {
            get { return montantFacture; }
            set { montantFacture = value; }
        }
        public char Region
        {
            get { return region; }
            set { region = value; }
        }

        public Nuite(DateTime Date, Commercial Commercial, double MontantFacture, char Region) : base(Date, Commercial)
        {
            this.montantFacture = MontantFacture;
            this.region = Region;
        }
    }
}
