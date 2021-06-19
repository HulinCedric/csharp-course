using System;
using System.Collections;
using System.Text;

namespace EvtDecouvert
{
    class ComptesClient
    {
        private string nomClient;
        private ArrayList comptes;
        
        // Constructeur
		//
        public ComptesClient (string nom)
        {
            nomClient = nom;
            comptes = new ArrayList();
        }

        // Propriétés
		//
        public string NomClient
        {
            get { return nomClient; }
            set { nomClient = value; }
        }

        public virtual void ouvrirCompte(Compte c)
        {
            comptes.Add(c);
        }

        public virtual void fermerCompte(string num)
        {
            foreach (Compte cpt in comptes) //faire un while + propre
                if (cpt.Numero == num)
                    comptes.Remove(cpt);
        }

        public void retirer(double somme, string num) //faire un while
        {
            foreach (Compte cpt in comptes)
                if (cpt.Numero == num)
                    cpt.retirer(somme);
        }
		
        public void deposer(double somme, string num)
        {
            foreach (Compte cpt in comptes)
                if (cpt.Numero == num)
                    cpt.deposer(somme);
        }
		
        public void consulter(string num)
        {
            foreach (Compte cpt in comptes)
                if (cpt.Numero == num) //faire while
                    cpt.consulter();
        }
		
        public void consulter()
        {
            foreach (Compte cpt in comptes) // faire while
                cpt.consulter();
        }
    }
}