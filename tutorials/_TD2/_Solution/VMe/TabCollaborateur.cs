using System;
using System.Collections;

namespace Exercice1
{
	public class TabCollaborateur
	{
		private ArrayList list;
		
		public TabCollaborateur ()
		{
			list= new ArrayList();
		}
		
		public void Add (Object o)
		{
			list.Add(o);	
		}
		
		public Collaborateur PlusHautSal()
		{
			double salMax= 0;
			int index= 0, i= 0;
			
			foreach (Collaborateur emp in list)
			{
				if (emp.Salaire > salMax) 
				{
					salMax= emp.Salaire;  
					index= i;
				}
				i++;
			}
			
			return (Collaborateur) list[index];
		}
		
		public Collaborateur PlusHautSal(string type)
		{
			double salMax= 0;
			int index= 0;
					
			for (int i= 0; i < list.Count ; i++)
			{				
				if (list[i].GetType().Name.Equals(type))
				{
					if (((Collaborateur) list[i]).Salaire > salMax) 
					{
						salMax= ((Collaborateur) list[i]).Salaire;
						index= i;
					}
				}
			}
			
			return (Collaborateur) list[index];
		}
		
		public void Sort() {
			list.Sort();
		}
		
		public void Sort(IComparer comp) {
			list.Sort(comp);
		}
		
		public IEnumerator GetEnumerator() {
			return list.GetEnumerator();
		}
	}
}
