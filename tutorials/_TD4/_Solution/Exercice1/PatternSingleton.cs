using System;
using System.Collections.Generic;
using CollaborateurDLL;

namespace Exercice1
{
	class CollaborateurList : List<Collaborateur>
	{
		private static CollaborateurList uniqueInstance;
        private CollaborateurList() { }
        public static CollaborateurList getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new CollaborateurList();
            return uniqueInstance;
        }
	}
}
