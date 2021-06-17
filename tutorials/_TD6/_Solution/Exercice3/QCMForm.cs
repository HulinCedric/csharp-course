using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercice3
{
    public partial class QCMForm : Form
    {
        private Dictionary<string, Dictionary<string, string>> reponse;

        public QCMForm()
        {
            InitializeComponent();

            Dictionary<string, string> Cinema = new Dictionary<string, string>();
            Cinema.Add("Question1", "Quelle actrice a été révélée par le film \"La Boum\" ?");
            Cinema.Add("Question2", "Quel comédien interprétait à la télé le célèbre commissaire Moulin ?");
            Cinema.Add("Question3", "Qui était l'animateur de l'émission télé \"l'école des fans\" ?");
            Cinema.Add("Reponse1", "Sophie Marceau");
            Cinema.Add("Reponse2", "Yves Rénier");
            Cinema.Add("Reponse3", "Jacques Martin");

            Dictionary<string, string> Musique = new Dictionary<string, string>();
            Musique.Add("Question1", "De quel instrument de musique Pablo Casals était-il virtuose ?");
            Musique.Add("Question2", "En solfège, à combien de noires équivaut le signe C ?");
            Musique.Add("Question3", "A quel compositeur doit-on Nabucco, Falstaff et Aïda ?");
            Musique.Add("Reponse1", "Violoncelle");
            Musique.Add("Reponse2", "4");
            Musique.Add("Reponse3", "Verdi");

            Dictionary<string, string> Nature = new Dictionary<string, string>();
            Nature.Add("Question1", "Comment s'appelle le père d'un bardot ?");
            Nature.Add("Question2", "Quel est le nom arachnéen de l'atèle d'Amérique du Sud ?");
            Nature.Add("Question3", "De quelle direction souffle le mistral ?");
            Nature.Add("Reponse1", "Un cheval");
            Nature.Add("Reponse2", "Singe-araignée");
            Nature.Add("Reponse3", "Du Nord");

            reponse = new Dictionary<string, Dictionary<string, string>>();
            reponse.Add("Cinéma", Cinema);
            reponse.Add("Musique", Musique);
            reponse.Add("Nature", Nature);

            ChoixQCM.SelectedIndex = 0;
        }

        private void ChoixQCM_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dictionary<string, string> associe= reponse[(string)ChoixQCM.SelectedItem];
            Question1.Text = associe[Question1.Name];
            Question2.Text = associe[Question2.Name];
            Question3.Text = associe[Question3.Name];
            Reponse1.Text = "";
            Reponse2.Text = "";
            Reponse3.Text = "";
        }

        private void Validation_Click(object sender, EventArgs e)
        {
            if (Reponse1.Text == "" || Reponse2.Text == "" || Reponse3.Text == "")
                MessageBox.Show("Vous n'avez pas repondu a toutes les questions !");
            else
            {
                Dictionary<string, string> associe = reponse[(string)ChoixQCM.SelectedItem];
                if (Reponse1.Text == associe[Reponse1.Name] && Reponse2.Text == associe[Reponse2.Name] && Reponse3.Text == associe[Reponse3.Name])
                    MessageBox.Show("Bravo, vous avez repondu correctement a toutes les questions !");
                else
                    MessageBox.Show("Vous n'avez pas bien repondu a toutes les questions !\n\nReponse n°1 = " + associe[Reponse1.Name] + "\nReponse n°2 = " + associe[Reponse2.Name] + "\nReponse n°3 = " + associe[Reponse3.Name] + "");
            }
        }
    }
}
