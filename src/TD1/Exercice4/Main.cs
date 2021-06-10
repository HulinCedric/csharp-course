using System;

namespace Exercice4
{
	public class Ville
    {
        private string nom;
        private int habitant;

        public Ville()
        {
            nom = "Default city";
            habitant = 1;
        }

        public Ville(string nom, int habitant)
        {
            this.nom = nom;
            this.habitant = habitant;
        }

        public string Nom
        {
            get { return nom; }
        }

        public int Habitant
        {
            get { return habitant; }
            set { habitant = value; }
        }

        public override string ToString()
        {
            if (habitant >= 500000)
            {
                return "Nom : " + nom + " , Population : " + habitant + " , Categorie : Grande";
            }
            else if ((habitant < 500000) && (habitant >= 100000))
            {
                return "Nom : " + nom + " , Population : " + habitant + " , Categorie : Moyenne";
            }
            else if ((habitant > 0) && (habitant < 100000))
            {
                return "Nom : " + nom + " , Population : " + habitant + " , Categorie : Petite";
            }
            else
            {
                return "ERROR";
            }
        }


        static void Main(string[] args)
        {
            Ville c1 = new Ville("Lyon", 15000);
            Ville c2 = new Ville("Paris", 300000);
            Ville c3 = new Ville("Dijon", 600000);
            Ville c4 = new Ville("Erreur habitans", -45);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            Capitale c5 = new Capitale("Paris", 300000, "France");
            Capitale c6 = new Capitale("Madrid", -45, "Espagne");

            Console.WriteLine(c5);
            Console.WriteLine(c6);
        }
    }

    public class Capitale : Ville
    {
        private string pays;

        public Capitale() : base()
        {
            pays = "Default counrty";
        }

        public Capitale(string nom, int habitant, string pays) : base(nom, habitant)
        {
            this.pays = pays;
        }

        public string Pays
        {
            get { return pays; }
            set { pays = value; }
        }

        public override string ToString()
        {
            string temp;
            temp = base.ToString();
            if (temp == "ERROR") return temp;
            return temp + " , Pays : " + pays;
        }
    }

    public class TabVille
    {
        Ville[] cities;    	// Tableau privé interne qui contient les villes.
        int max;            // nombre maximum d’éléments

        // Le constructeur qui initialise le tableau.
        public TabVille(int max)
        {
            cities = new Ville[max];
            this.max = max;
        }
		
		public int Max
		{
			get { return max; }
		}

        // L'indexeur qui retourne l'index de la ville à partir du nom.
        public int this[string nom]
        {
            get
            {
                int index= 1;
				foreach (Ville ville in cities)
				{
					if (ville.Nom == nom) return index;
					index++;
				}
				return -1;
            }
        }

        // L'indexeur qui retourne ou affecte une ville à partir de l’index.
        public Ville this[int i]
        {
            get { return (cities[i]); }
            set { cities[i] = value; }
        }
    }
}
