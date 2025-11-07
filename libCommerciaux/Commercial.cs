namespace libCommerciaux
{
    public class Commercial
    {
        private string nom;
        private string prenom;
        private char categorie;
        private int puissanceVoiture;
        private List<NoteFrais> mesNotes;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string getNom()
        {
            return nom;
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string getPrenom()
        {
            return prenom;
        }
        public char Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        public char getCategorie()
        {
            return categorie;
        }
        public int PuissanceVoiture
        {
            get { return puissanceVoiture; }
            set { puissanceVoiture = value; }
        }
        public int getPuissanceVoiture()
        {
            return puissanceVoiture;
        }
        public List<NoteFrais> MesNotes
        {
            get { return mesNotes; }
            set { mesNotes = value; }
        }
        public List<NoteFrais> getMesNoteFrais()
        {
            return mesNotes;
        }

        public Commercial(string Nom, string Prenom, int Puissance, char Categorie)
        {
            nom = Nom;
            prenom = Prenom;
            categorie = Categorie;
            puissanceVoiture = Puissance;
            mesNotes = new List<NoteFrais>();
        }

        public void AjouterNoteFrais(NoteFrais nf)
        {
            mesNotes.Add(nf);
        }

        public override string ToString()
        {
            return $"Nom : {nom} Prénom : {prenom} Puissance voiture : {puissanceVoiture} Categorie : {categorie}";
        }
    }
}
