using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libCommerciaux
{
    public class ServiceCommercial
    {
        private List<Commercial> lesCommerciaux;
        public List<Commercial> LesCommerciaux
        {
            get { return lesCommerciaux; }
            set { lesCommerciaux = value; }
        }

        public ServiceCommercial()
        {
            this.lesCommerciaux = new List<Commercial>();
        }

        public void ajouterCommercial(Commercial c)
        {
            lesCommerciaux.Add(c);
        }

        public int nbFraisNonRembourses()
        {
            int nb_frais = 0;
            foreach (Commercial commercial in lesCommerciaux)
            {
                foreach (NoteFrais note in commercial.MesNotes)
                {
                    if (note.getEstRembourse() == false)
                    {
                        nb_frais += 1;
                    }
                }
            }
            return nb_frais;
        }
    }
}
