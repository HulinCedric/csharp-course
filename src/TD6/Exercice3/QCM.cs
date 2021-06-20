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
                    "En quelle année a été lancé le projet NET par Microsoft ?",
                    "Quels éléments ne sont pas supportés par .NET ?",
                    "Comment gère-t-on les erreurs à l'exécution dans un programme .NET ?"
                },
                new string[3][]{
                    new string[4]{"2000", "2002", "2005","2006"},
                    new string[3]{"Héritage multiple", "Pointeurs", "Interfaces"},
                    new string[3]{"On ne peut pas gérer les erreurs", "Les exceptions", "les errors"}
                
                },
                new string[3]{
                               "2000","Héritage multiple","Les exceptions"
                }),
                /********************** Deuxième QCM **********************/
                new QCM(
                "Madonna",
                new string[3]{
                    "Quel est le vrai nom de madonna ?",
                    "Quand et ou est-elle née ?",
                    "En quelle année sort-elle son premier album intitulé simplement \"Madonna\" ?"
                },
                new string[3][]{
                    new string[3]{"Louise Veronica Ciccone", "Léonora De Ricca", "Marcella Majda Cegiz"},
                    new string[3]{"Le 18 août à Detroit", "Le 16 août 1958 à Bay City", "Le 17 juillet à New York"},
                    new string[2]{"1983", "1982"}
                },
                new string[3]{
                    "Louise Veronica Ciccone","Le 16 août 1958 à Bay City","1983"
                }),
                /********************** Troisième QCM **********************/
                new QCM(
                "Gason Lagaffe",
                new string[3]{
                    "Quel est le prénom de Lebrac ?",
                    "Comment s'appelle la souris de Lagaffe ?",
                    "Qui pousse sans arrêt le célèbre cri \"Roognntuddjuu !!!\" ?"
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