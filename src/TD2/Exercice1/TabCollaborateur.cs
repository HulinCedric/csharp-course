using System;
using System.Collections;

namespace Exercice1
{
	public class TabCollaborateur : ArrayList
	{		
		public Collaborateur PlusHautSal()
		{
			Collaborateur i = (Collaborateur)this[0];
			foreach(Collaborateur j in this)
				i = i.PlusHautSal(j);
			return i;
		}
		
		private Collaborateur Premier(string type)
		{
			foreach (Collaborateur j in this)
				if (type.Equals(j.GetType().Name))
					return j;
			return null;
		}
		
		public Collaborateur PlusHautSal(string type)
		{
			// Recherche premier du type
			//
			Collaborateur i = Premier(type);
			if (i == null) return null;
			foreach (Collaborateur j in this)
				if (type.Equals(j.GetType().Name))
					i = i.PlusHautSal(j);
			return i;
		}
	}
}
