using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Cat_Cafe_Agenda
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactForm contactForm = new ContactForm();
            contactForm.ShowDialog();
            this.Close();
        }

        private void BtnLogEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventForm eventForm = new EventForm();
            eventForm.ShowDialog();
            this.Close();
        }
    }
}
