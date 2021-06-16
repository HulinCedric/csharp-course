using System;

namespace Exercice2
{
	class MainClass
	{
        public static void Main(string[] args)
        {
            // Creation receiver, command, et invoker 
            Receiver receiver = new Receiver(3);
            Invoker invoker = new Invoker();
            
            // Set et execute command 
            invoker.SetCommand(new MultiplierPar(receiver, 2));
            invoker.SetCommand(new AdditionnerAvec(receiver, 5));
            invoker.SetCommand(new MultiplierPar(receiver, 50));
            invoker.SetCommand(new AdditionnerAvec(receiver, 1759));
            invoker.SetCommand(new SoustraireAvec(receiver, 1987));
            invoker.DoCommands();
			
			// Affichage du resultat
			//
			Console.WriteLine();
            Console.WriteLine("***** Resultat Final *****");
			Console.WriteLine();
            Console.WriteLine("-> " + receiver.Nombre);			
			
			
			Console.WriteLine();
            Console.WriteLine("***** UnDo *****");
			Console.WriteLine();
            
			invoker.UnDoCommands();
            Console.WriteLine("-> " + receiver.Nombre);
			invoker.UnDoCommands();
            Console.WriteLine("-> " + receiver.Nombre);	
			invoker.UnDoCommands();
            Console.WriteLine("-> " + receiver.Nombre);
			invoker.UnDoCommands();
            Console.WriteLine("-> " + receiver.Nombre);
			
			Console.WriteLine();
			Console.WriteLine("***** Resultat Initial *****");
			Console.WriteLine();
			
			invoker.UnDoCommands();
            Console.WriteLine("-> " + receiver.Nombre);
			
			Console.WriteLine();
			Console.WriteLine("***** ReDo *****");
			Console.WriteLine();
			
            invoker.ReDo();
			Console.WriteLine("-> " + receiver.Nombre);
			invoker.ReDo();
			Console.WriteLine("-> " + receiver.Nombre);
			invoker.ReDo();
			Console.WriteLine("-> " + receiver.Nombre);
			invoker.ReDo();
			Console.WriteLine("-> " + receiver.Nombre);
			invoker.ReDo();
			Console.WriteLine("-> " + receiver.Nombre);
			
			Console.WriteLine();
			Console.WriteLine("***** Retour Resultat Final *****");
			Console.WriteLine();
			
			int sorties = (int)receiver.Nombre / 100;
            int age = receiver.Nombre - (sorties * 100);
            Console.WriteLine("Nombre de sorties par semaine : " + sorties );
            Console.WriteLine("Votre age : " + age);
        }
	}
}
