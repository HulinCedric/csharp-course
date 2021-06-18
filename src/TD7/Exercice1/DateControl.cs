using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercice1
{
    public partial class DateControl : UserControl
    {
        MonthCalendar calendar;

        public DateControl()
        {
            InitializeComponent();
            BringToFront();
        }

        public string Textdate
        {
            get { return TextBox.Text; }
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            calendar = new MonthCalendar();
            Controls.Add(calendar);
            calendar.BringToFront();
            calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendar_DateSelected);
            calendar.Location = new Point(calendar.Location.X+20, calendar.Location.Y + 45);
            Width += calendar.Width - Width + 30;
            Height += calendar.Height;
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            TextBox.Text = calendar.SelectionStart.ToShortDateString();
            Height -= calendar.Height;
            Width -= calendar.Width - Width + 30;
            Controls.Remove(calendar);
            calendar.Dispose();
            calendar = null;
        }
    }
}
