using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace libCommerciaux
{
    public class RepasMidi : NoteFrais
    {
        private double montantFacture;

        public double MontantFacture
        {
            get { return montantFacture; }
            set { montantFacture = value; }
        }

        public RepasMidi(DateTime Date, Commercial LeCommercial, double MontantFacture) : base(Date, LeCommercial)
        {
            this.montantFacture = MontantFacture;
        }

        public override double calculMontantARembourser()
        {
            double montant;
            char categorie = this.LeCommercial.Categorie;
            switch (categorie)
            {
                case 'A':
                    montant = 25;
                    break;
                case 'B':
                    montant = 22;
                    break;
                case 'C':
                    montant = 20;
                    break;
                default:
                    montant = 0;
                    break;
            }
            if (montantFacture < montant)
            {
                montant = montantFacture;
            }
            return montant;
        }

        public override string ToString()
        {
            return base.ToString() + $" payé : {montantFacture} €";
        }
    }
}
