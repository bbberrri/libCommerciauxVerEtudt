using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public class NoteFrais
    {
        private int numero;
        private DateTime date;
        private double montant;
        private bool rembourse;
        private Commercial commercial;
        //public int Numero
        //{
        //    get { return numero; }
        //    set { numero = value; }
        //}
        //public DateTime Date
        //{
        //    get { return date; }
        //    set { date = value; }
        //}
        //public bool Rembourse
        //{
        //    get { return rembourse; }
        //    set { rembourse = value; }
        //}
        public double Montant
        {
            get { return Montant; }
            set { Montant = value; }
        }
        public Commercial Commercial
        {
            get { return commercial; }
            set { commercial = value; }
        }
        public NoteFrais(DateTime Date, Commercial Commercial)
        {

            this.date = Date;
            this.commercial = Commercial;
        }

    }
}
