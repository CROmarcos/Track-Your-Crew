using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackYourWorkers
{
    public partial class Pocetna : Form
    {
        private string korisnik;
        public Pocetna(string user)
        {
            InitializeComponent();
            korisnik=user;
            if (korisnik == "manager")
            {
                label1.Text += " projektni menadžer!";
            }
            else
            {
                label1.Text += " " + user + "!";
            }
        }

        private void btnStudenti_Click(object sender, EventArgs e)
        {
            Studenti forma = new Studenti(korisnik);
            forma.ShowDialog();
        }

        private void btnRadnaMjesta_Click(object sender, EventArgs e)
        {
            RadnaMjesta forma = new RadnaMjesta();
            forma.ShowDialog();
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            Ugovori forma = new Ugovori(korisnik);
            forma.ShowDialog();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            lbOdjava.BackColor = Color.Transparent;
        }

        private void lbOdjava_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm forma = new LoginForm();
            forma.ShowDialog();
            Close();
        }
    }
}
