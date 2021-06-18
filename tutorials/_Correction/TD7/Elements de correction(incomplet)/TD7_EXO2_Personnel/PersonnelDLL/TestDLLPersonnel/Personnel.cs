using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PersonnelDLL;

namespace TestDLLPersonnel
{
    /// <summary>
    /// Description résumée de Class1.
    /// </summary>


    public class TabCollaborateur : ArrayList
    {
        
		
        
       public Collaborateur PlusHautSal()
        {
            Collaborateur i = (Collaborateur)this[0];
            foreach(Collaborateur j in this)
            {
                i=i.PlusHautSal(j);
            }
            return i;
        }


        //recherche premier du type
       Collaborateur Premier(string type)
       {

           foreach (Collaborateur j in this)
           {
               Type t = j.GetType();
               string s = t.ToString();
               int deb = s.LastIndexOf(".") + 1;
               s = s.Substring(deb, s.Length - deb);
               if (s.Equals(type))
               {
                  
                   return j;
               }
           }
           
           return null;
       }


       public Collaborateur PlusHautSal(string type)
       {
           // recherche premier du type
           Collaborateur i = Premier(type);
           if (i == null) return null;
           foreach (Collaborateur j in this)
           {
               Type t = j.GetType();
               string s = t.ToString();
               int deb = s.LastIndexOf(".") + 1;
               s = s.Substring(deb, s.Length - deb);
               if (s.Equals(type))
                   i = i.PlusHautSal(j);
           }
           return i;
       }

     
    }

}
