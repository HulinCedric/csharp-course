using System;
using System.Collections.Generic;
using System.Text;

namespace EvtDecouvert
{
    public class Responsable
    {
        string nom;
        public  Responsable(string nom) { this.nom = nom; }
        public void Prevenir(object sender, DecouvertEventArgs e)
        {
            //-- gestionnaire d'événement RetirerNonAut
            // envoyer un mail automatique par exemple
			//
            Console.WriteLine( "{0} est prevenu du decouvert du {1}",nom, e);
       	}
  	}

    public class prog
    {
        public static void Main()
        {
			ComptesClient cptSuisse = new ComptesClient("Johnny");
            
			CompteCourant cc1 = new CompteCourant("1234", "Johnny", 1000,300);
			Responsable R1 = new Responsable("Lecat");
			cc1.RetirerNonAut += R1.Prevenir;
			cptSuisse.ouvrirCompte(cc1);
            
			CompteCourant cc2 = new CompteCourant("567", "Johnny", 20000,5000);
			Responsable R2 = new Responsable("Hulin");
			cc2.RetirerNonAut += R2.Prevenir;
            cptSuisse.ouvrirCompte(cc2);
            
			CompteLivret cl1 = new CompteLivret("890", "Johnny", 500000, 0.2);
            cptSuisse.ouvrirCompte(cl1);
           
            cptSuisse.deposer(500, "1234");
            cptSuisse.deposer(10000, "567");
            cptSuisse.retirer(10000, "567");
			
            Console.WriteLine("---- tous les comptes -----");
            cptSuisse.consulter();

            Console.WriteLine("---- Un compte -----");
            cptSuisse.consulter("1234");
			
			Console.WriteLine("---- Essaie du decouvert -----");			
		    
			cc1.retirer(10000);
			Console.WriteLine();
            cc1.consulter();
        }
    }
}