using System;

namespace Exercice5
{
	class Fraction 
	{
		int numerator;
		int denominator=1;

        public void Afficher()
        {
            Console.WriteLine(ToString());
        }

		public static int Pgcd(int nb1,int nb2)
		{
			int temp;
			if (nb2 > nb1)
			{	
				temp=nb1;
				nb1=nb2;
				nb2=temp;
			}
			if (nb1<0)nb1=-nb1;
			if (nb2<0)nb2=-nb2;
			if ((nb1%nb2) == 0)
				return nb2;
			else return Pgcd(nb2,nb1%nb2);
		}
		
		private void reduire() 
		{
			int signe, pgcd;

 		 	// Traiter le cas particulier d'une fraction nulle
   			//
   			if (numerator == 0) {
		      	denominator= Math.Abs(denominator); 
		      	return;
		   	}
   
		   	// Determiner le signe du resultat
		   	//
		   	if (numerator > 0)
		   	 	if (denominator > 0) signe= 1;
		      	else signe= -1;
		   	else 
				if (denominator > 0) signe= -1;
		        else signe= 1;
		
		  	// Calculer le PGCD des deux membres
		   	//
		   	pgcd= Pgcd(Math.Abs(numerator), Math.Abs(denominator));
		
		   	// Diviser chaque membre par le PGCD
		   	//
		   	numerator  = signe*Math.Abs(numerator)/pgcd;
		   	denominator= Math.Abs(denominator)/pgcd;
		}

		public Fraction()
		{
			numerator=0;
		}
		
		public Fraction (int num) 
		{
			numerator=num;
		}
		
		public Fraction (int num,int den ) 
		{
			numerator=num; 
			denominator=den; 
			reduire();
		}
		
		public override string ToString()
		{
			return numerator + "/" + denominator;
		}

		public static Fraction  operator +(Fraction f,int nb) 
        {
			// Fixer le numerateur du resultat
   			//	
			int num= f.numerator + nb * f.denominator;
			
			// Restituer le resultat
   			//
        	   	return new Fraction(num, f.denominator);
        }

		public static Fraction operator +(int nb,Fraction f)
        {
			// Restituer le resultat
   			//
            return f + nb;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
			// Fixer le denominateur du resultat
   			//	
            int den= f1.denominator * f2.denominator;
			
			// Fixer le numerateur du resultat
   			//	
			int num= f1.denominator*f2.numerator + f2.denominator*f1.numerator;
			
			// Restituer le resultat
   			//
			return new Fraction(num, den);
        }
	}

	class Prog
	{
		public static void Main()
		{
			Fraction a = new Fraction();
			a.Afficher();				//Affiche 0/1
			Fraction b= new Fraction(2,-6);	
			b.Afficher();				// Affiche –1/3
			Fraction c= new Fraction(8,3);	
			a=b+c;
			a.Afficher();				//Affiche 7/3
			a=b+3;					
			a.Afficher();				//Affiche  8/3
			a=7 + b;
			a.Afficher();				//Affiche 20/3
		}		
	}
}
