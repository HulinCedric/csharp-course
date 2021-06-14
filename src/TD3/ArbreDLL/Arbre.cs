using System;

namespace ArbreDLL
{
	public class Arbre<T> where T : IComparable <T>
    {
        private bool vide;
        private T valeurRacine;
        private Arbre<T> arbreGauche;
        private Arbre<T> arbreDroit;

        public Arbre()
        {
         	vide= true;
        }

        public Arbre(T valeurRacine, params T[] tabValeur)
        {
            vide= false;
            this.valeurRacine= valeurRacine;
            arbreGauche= new Arbre<T>();
            arbreDroit= new Arbre<T>();
            foreach (T elem in tabValeur)
                Add(elem);
        }

        public T ValeurRacine
        {
            get { return valeurRacine; }
            set { valeurRacine= value; }
        }

        public bool Vide
        {
            get { return vide; }
        }

        public Arbre<T> ArbreGauche
        {
            get { return arbreGauche; }
            set { arbreGauche= value; }
        }

        public Arbre<T> ArbreDroit
        {
            get { return arbreDroit; }
            set { arbreDroit= value; }
        }

        public void Add(T valeur)
        {
           	if (vide)
            {
                vide= false;
                valeurRacine= valeur;
				arbreGauche= new Arbre<T>();
				arbreDroit= new Arbre<T>();
            }
            else
            {
                if (valeurRacine.CompareTo(valeur) > 0)
                    arbreGauche.Add(valeur);
                else
                    arbreDroit.Add(valeur);
            }
        }

        public void Parcours()
        {
            if (!vide)
            {
                arbreGauche.Parcours();
                Console.WriteLine(valeurRacine);
                arbreDroit.Parcours();
            }
        }

        public void Max(out T val, out Arbre<T> Noeud)
        {
            if (vide) 
			{ 
				Noeud= new Arbre<T>(); 
				val= default(T);
			}
            else 
			{
				if (arbreDroit.vide == true) 
				{ 
					val= valeurRacine; 
					Noeud= this;  
				}
            		else arbreDroit.Max(out val, out Noeud);
			}
        }

        public void Remove(T val)
        {
            Arbre<T> N; 
			T max;
            
			if (vide) return;
            else 
			{
				if (val.CompareTo(valeurRacine) < 0) arbreGauche.Remove(val);
                	else 
				{
					if (val.CompareTo(valeurRacine) > 0) arbreDroit.Remove(val);
                  	else
					{
						if (arbreGauche.vide && arbreDroit.vide) vide = true;
						else 
						{
							if (arbreGauche.vide && !arbreDroit.vide) 
							{
								arbreDroit.Max(out max, out  N); 
								valeurRacine= max; 
								N.vide= true; 
							}
                            	else 
							{
								if (!arbreGauche.vide && arbreDroit.vide) 
								{ 
									arbreGauche.Max(out max, out  N); 
									valeurRacine= max; 
									N.vide= true; 
								} 
							}
						}
					}
				}
			}
		}
    }
}
