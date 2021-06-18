using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class UserControlDate : UserControl
    {
        MonthCalendar m;
        DateTime d;

       

        public UserControlDate()
        {
            InitializeComponent();
            
           
        }

       

       
       public void textBox1_Click(object sender, EventArgs e)
        
        {
            
            m = new MonthCalendar();
            this.Controls.Add(m);

           // Ajuster taille du composant?
            this.Size = new System.Drawing.Size(290, 215);
            m.Location = new Point(70, 30);
          
            m.Name = "m";
         
            this.m.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.m_DateSelected);
            textBox1.Text = m.SelectionRange.Start.ToShortDateString();
            d = new DateTime();
            d = m.SelectionRange.Start;
            
           


        }

        private void m_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = m.SelectionRange.Start.ToShortDateString();
            d = m.SelectionRange.Start;
            this.Controls.Remove(m);
            this.Size = new System.Drawing.Size(172, 39);


        }

        public DateTime Date
        {
           get{ return d;}
        }

        
       
    }
  
}
