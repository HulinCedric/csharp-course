using System;
using System.Collections.Generic;
using System.Text;

namespace EvtDecouvert
{
    public abstract class Compte : Icompte
    {
        private double solde ;
        private string titulaire;
        private string numero;
         
        public Compte(string num, string nom)
        {
            numero = num;
            titulaire = nom;
            solde = 0;
        }
		
        public Compte(string num, string nom, double depot) : this(num, nom)
        {
            solde = depot;
        }
       
        public virtual double Solde
        {
            get { return solde; }
            protected set { solde = value; }
        }
		
        public string Titulaire
        {
            get { return titulaire; }
            set { titulaire = value; }
        }
		
        public string Numero
        {
            get { return numero; }
        }

        public override string ToString()
        {
            return "Compte n " + numero + " de M. "+ titulaire + "  solde = " +solde +" E" ;
        }
        
        public virtual void consulter()
        {
            Console.WriteLine(this.GetType());
            Console.WriteLine(this);
            Console.WriteLine();
        }

        public virtual void deposer(double somme)
        {
            solde += somme;
        }
		
        public virtual void retirer(double somme)
        {
            if (somme <= solde)
                solde -= somme;
        }
    }
}