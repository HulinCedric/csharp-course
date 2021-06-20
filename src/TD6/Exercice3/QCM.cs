using System;

namespace Exercice_7
{
    public class QCM
    {
        private string titre;
        private string[] questions;
        private string[][] choix;
        private string[] reponses;

        public QCM(string titre, string[] questions, string[][] choix, string[] reponses)
        {
            this.titre = titre;
            this.questions = questions;
            this.choix = choix;
            this.reponses = reponses;
        }

        public string Titre
        {
            get { return titre; }
        }

        public string[] Questions
        {
            get { return questions; }
        }

        public string[][] Choix
        {
            get { return choix; }
        }

        public string[] Reponses
        {
            get { return reponses; }
        }

        public override string ToString()
        {
            return titre;
        }
    }


    public class QCMList
    {
        private static QCM[] qcms;

        static QCMList()
        {
            qcms = new QCM [3]{
                /********************** Premier QCM **********************/
                new QCM(
                "NET",
                new string[3]{
                    "En quelle ann�e a �t� lanc� le projet NET par Microsoft ?",
                    "Quels �l�ments ne sont pas support�s par .NET ?",
                    "Comment g�re-t-on les erreurs � l'ex�cution dans un programme .NET ?"
                },
                new string[3][]{
                    new string[4]{"2000", "2002", "2005","2006"},
                    new string[3]{"H�ritage multiple", "Pointeurs", "Interfaces"},
                    new string[3]{"On ne peut pas g�rer les erreurs", "Les exceptions", "les errors"}
                
                },
                new string[3]{
                               "2000","H�ritage multiple","Les exceptions"
                }),
                /********************** Deuxi�me QCM **********************/
                new QCM(
                "Madonna",
                new string[3]{
                    "Quel est le vrai nom de madonna ?",
                    "Quand et ou est-elle n�e ?",
                    "En quelle ann�e sort-elle son premier album intitul� simplement \"Madonna\" ?"
                },
                new string[3][]{
                    new string[3]{"Louise Veronica Ciccone", "L�onora De Ricca", "Marcella Majda Cegiz"},
                    new string[3]{"Le 18 ao�t � Detroit", "Le 16 ao�t 1958 � Bay City", "Le 17 juillet � New York"},
                    new string[2]{"1983", "1982"}
                },
                new string[3]{
                    "Louise Veronica Ciccone","Le 16 ao�t 1958 � Bay City","1983"
                }),
                /********************** Troisi�me QCM **********************/
                new QCM(
                "Gason Lagaffe",
                new string[3]{
                    "Quel est le pr�nom de Lebrac ?",
                    "Comment s'appelle la souris de Lagaffe ?",
                    "Qui pousse sans arr�t le c�l�bre cri \"Roognntuddjuu !!!\" ?"
                },
                new string[3][]{
                    new string[3]{"Jean", "Jules", "Yves"},
                    new string[3]{"Miette", "Cheese", "Souris"},
                    new string[3]{"Fantasio", "Prunelle", "Jules de chez Smith en face"}
                },
                new string[3]{
                    "Yves","Cheese","Prunelle"
                })
            };
        }

        public static QCM[] QCMS
        {
            get { return qcms; }
        }
    }
}