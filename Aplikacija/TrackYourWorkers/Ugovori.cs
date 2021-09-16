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
    public partial class Ugovori : Form
    {
        private string korisnik;
        public Ugovori(string user)
        {
            InitializeComponent();
            korisnik = user;            
        }

        private void Ugovori_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 130;
            PrikaziUgovore();
            if (korisnik == "zaposlenik")
            {
                btnOtkaziUgovor.Hide();
                btnPodnesiUgovor.Hide();
                Height = 268;
            }
        }

        private void PrikaziUgovore()
        {
            BindingList<OtvoreniUgovori> lista = null;
            using (var db = new RadniSatiEntities())
            {
                lista = new BindingList<OtvoreniUgovori>(db.OtvoreniUgovori.ToList());
            }
            otvoreniUgovoriBindingSource.DataSource = lista;
        }

        private void btnOtvoriUgovor_Click(object sender, EventArgs e)
        {
            DodajUgovor forma = new DodajUgovor();
            forma.ShowDialog();
            PrikaziUgovore();
        }

        private void btnPodnesiUgovor_Click(object sender, EventArgs e)
        {
            Student student = null;
            Ugovor ugovor = null;
            if (otvoreniUgovoriBindingSource.Current is OtvoreniUgovori otvUgovor)
            {
                using (var db = new RadniSatiEntities())
                {
                    foreach (var itemStudent in db.Student)
                    {
                        if (otvUgovor.OIB == itemStudent.OIB)
                        {
                            student = itemStudent;
                        }
                    }
                    foreach (var itemUgovor in db.Ugovor)
                    {
                        if (student.RadnikId == itemUgovor.Student && otvUgovor.Mjesec == itemUgovor.Mjesec)
                        {
                            ugovor = itemUgovor;
                        }
                    }
                }
                PodnesiUgovor forma = new PodnesiUgovor(ugovor);
                forma.ShowDialog();
                PrikaziUgovore();
            }
        }

        private void btnOtkaziUgovor_Click(object sender, EventArgs e)
        {
            Student student = null;
            Ugovor ugovor = null;
            if (otvoreniUgovoriBindingSource.Current is OtvoreniUgovori otvUgovor)
            {
                using (var db = new RadniSatiEntities())
                {
                    foreach (var itemStudent in db.Student)
                    {
                        if (otvUgovor.OIB == itemStudent.OIB)
                        {
                            student = itemStudent;
                        }
                    }
                    foreach (var itemUgovor in db.Ugovor)
                    {
                        if (student.RadnikId == itemUgovor.Student && otvUgovor.Mjesec == itemUgovor.Mjesec)
                        {
                            ugovor = itemUgovor;
                        }
                    }
                    db.Ugovor.Attach(ugovor);
                    if (ugovor.Isplaceno == false)
                    {
                        db.Ugovor.Remove(ugovor);
                    }
                    db.SaveChanges();
                    PrikaziUgovore();
                }
            }
        }
    }
}
