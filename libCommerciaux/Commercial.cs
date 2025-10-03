namespace libCommerciaux
{
    public class Commercial
    {
        private string nom;
        private string prenom;
        private char categorie;
        private int puissance;
        private List<NoteFrais> listNoteFrais;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public char Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        public int Puissance
        {
            get { return puissance; }
            set { puissance = value; }
        }
        public List<NoteFrais> ListNoteFrais
        {
            get { return listNoteFrais; }
            set { listNoteFrais = value; }
        }
        public Commercial(string Prenom, string Nom, int Puissance, char Categorie)
        {
            nom = Nom;
            prenom = Prenom;
            categorie = Categorie;
            puissance = Puissance;
            listNoteFrais = new List<NoteFrais>();
        }
        public void AjouterNoteFrais(NoteFrais nf)
        {
            listNoteFrais.Add(nf);
        }
        public override string ToString()
        {
            return $"Nom : {nom} Prénom : {prenom} Puissance voiture : {puissance} Categorie : {categorie}";
        }
    }
}
