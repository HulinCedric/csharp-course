using System;
using System.Text;
using System.Collections;

namespace EvtDecouvert
{
    interface Icompte
    {
        // Propri�t�s
		//
        double Solde
        { get; }
        string Titulaire
        { get; set; }
        string Numero
        { get; }

        void consulter();
        void deposer(double somme);
        void retirer(double somme);
   	}
}