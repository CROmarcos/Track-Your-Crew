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
    public partial class LoginForm : Form
    {
        private string user;
        private Korisnik korisnik;
        private bool potvrdjen;

        private void LoginForm_Load(object sender, EventArgs e)
        {
            user = null;
            label1.Text = String.Empty;
            rbZaposlenik.Checked = true;
        }

        public LoginForm()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            label1.Text = String.Empty;
            potvrdjen = false;
            user = UcitajKorisnika();
            using (var db = new RadniSatiEntities())
            {
                foreach (var item in db.Korisnik)
                {
                    if (item.KorisnickoIme == user)
                    {
                        korisnik = item;
                        if (tbPassword.Text == item.Lozinka)
                        {
                            potvrdjen = true;
                        }
                    }
                }
            }
            if (potvrdjen)
            {
                Hide();
                Pocetna forma = new Pocetna(user);
                forma.ShowDialog();
                Close();
            }
            else
            {
                label1.Text = "Pogrešna lozinka, molimo unesite ponovno!";
                tbPassword.Text = String.Empty;
            }
        }

        private string UcitajKorisnika()
        {
            string korisnickoIme;
            if (rbDirektor.Checked)
            {
                korisnickoIme = "direktor";
            }
            else if (rbManager.Checked)
            {
                korisnickoIme = "manager";
            }
            else
            {
                korisnickoIme = "zaposlenik";
            }
            return korisnickoIme;
        }
    }
}
