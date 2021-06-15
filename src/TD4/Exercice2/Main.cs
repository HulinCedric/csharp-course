using System;

namespace Exercice2
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			Tauren Diablon=new Tauren("Diablon", "15");
			Diablon.Animer();
			Diablon.seBattre();
			
			Orc Azag=new Orc("Azag", "5");
			Azag.Animer();
			Azag.seBattre();
			
			Troll ArKor= new Troll("ArKor", "Heinken");
			ArKor.Animer();	
			ArKor.seBattre();
			
			Humain Kir= new Humain("Kir", "Bleu");
			Kir.Animer();
			Kir.seBattre();
			
			Diablon.Arme=new CombatEpee();
			Diablon.seBattre();
		}
	}
}