using System;
using System.Collections;

namespace Exercice1
{
	public class TriSalaire : IComparer
	{
		public int Compare(object o1, object o2)
        {
            Collaborateur c1 = (Collaborateur)o1;
            Collaborateur c2 = (Collaborateur)o2;
			
            return c1.Salaire().CompareTo(c2.Salaire());
        }
	}
}
