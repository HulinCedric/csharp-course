using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace PatternCommande
{


	class CReceveur
	{
		private long ValInterne = 0;
		public long Val {
			get { return ValInterne; }
			set { ValInterne = value; }
		}
		
		//Action inutile ici
	}

	interface ICommand
	{
		void Do ();
		void Undo ();
	}

	class CAjou : ICommand
	{
		public CAjou (CReceveur Number, long Val)
		{
			m_Number = Number;
			m_Val = Val;
		}
		public void Do ()
		{
			m_Number.Val += m_Val;
		}
		public void Undo ()
		{
			m_Number.Val -= m_Val;
		}
		private CReceveur m_Number;
		private long m_Val;
	}

	class CMult : ICommand
	{
		public CMult (CReceveur Number, long Val)
		{
			m_Number = Number;
			m_Val = Val;
		}
		public void Do ()
		{
			m_Number.Val *= m_Val;
		}
		public void Undo ()
		{
			m_Number.Val /= m_Val;
		}
		private CReceveur m_Number;
		private long m_Val;
	}


	class CInvoker
	{
		public void AddCommand (ICommand Command)
		{
			m_ListCommand.Add (Command);
		}
		public void DoCommands ()
		{
			// execute les commandes dans l'ordre 
			foreach (ICommand Command in m_ListCommand)
				Command.Do ();
		}
		public void UndoCommands ()
		{
			// undo les commandes dans l'ordre inverse
			m_ListCommand.Reverse ();
			foreach (ICommand Command in m_ListCommand)
				Command.Undo ();
			m_ListCommand.Reverse ();
		}
		private ArrayList m_ListCommand = new ArrayList ();
	}


	class Prog
	{
		// constantes 
		public static readonly long JourSemaine = 3;
		public static readonly bool bAnnivCetAnnee = true;
		public static readonly long AnneeDeNaissance = 1975;
		public static void Main ()
		{
			// construit la liste des commandes
			CReceveur TheNumber = new CReceveur ();
			CInvoker TheInvoker = new CInvoker ();
			TheInvoker.AddCommand (new CMult (TheNumber, 2));
			TheInvoker.AddCommand (new CAjou (TheNumber, 5));
			TheInvoker.AddCommand (new CMult (TheNumber, 50));
			TheInvoker.AddCommand (new CAjou (TheNumber, (bAnnivCetAnnee ? 1760 : 1759)));
			TheInvoker.AddCommand (new CAjou (TheNumber, -1956));
			
			// exécute puis undo les commandes
			TheNumber.Val = JourSemaine;
			Console.WriteLine ("Début: {0}", TheNumber.Val);
			TheInvoker.DoCommands ();
			Console.WriteLine ("Aprés exécution: {0}", TheNumber.Val);
			TheInvoker.UndoCommands ();
			Console.WriteLine ("Après undo: {0}", TheNumber.Val);
		}
	}
}