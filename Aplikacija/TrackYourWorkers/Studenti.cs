using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;

namespace TrackYourWorkers
{
    public partial class Studenti : Form
    {
        private string korisnik;
        public Studenti(string user)
        {
            InitializeComponent();
            korisnik = user;
        }
        private void Studenti_Load(object sender, EventArgs e)
        {
            if (korisnik != "direktor")
            {
                Height = 418;
                btnObrisi.Hide();
            }
            PrikaziStudente();
            Student selected = studentBindingSource.Current as Student;
            if (selected != null)
            {
                PrikaziUgovore(selected);
            }
        }

        private void btnUnesiStudenta_Click(object sender, EventArgs e)
        {
            dgvStudenti.ClearSelection();
            DodajStudenta forma = new DodajStudenta();
            forma.Text = "Novi student";
            forma.ShowDialog();
            PrikaziStudente();
        }

        private void btnIzmijeniStudenta_Click(object sender, EventArgs e)
        {
            if (studentBindingSource.Current is Student selectedStudent)
            {
                DodajStudenta forma = new DodajStudenta(selectedStudent);
                forma.Text = "Student: " + selectedStudent.Ime + " " + selectedStudent.Prezime;
                forma.ShowDialog();
                PrikaziStudente();
            }
        }

        private void PrikaziStudente()
        {
            BindingList<Student> popisStudenata = null;
            using (var db = new RadniSatiEntities())
            {
                popisStudenata = new BindingList<Student>(db.Student.ToList());
            }
            studentBindingSource.DataSource = popisStudenata;
        }

        private void PrikaziUgovore(Student student)
        {
            BindingList<IsplaceniUgovori> prikaz = null;
            using (var db = new RadniSatiEntities())
            {
                prikaz = new BindingList<IsplaceniUgovori>();
                foreach (var item in db.IsplaceniUgovori.ToList())
                {
                    if (student.OIB == item.OIB)
                    {
                        prikaz.Add(item);
                    }
                }
                isplaceniUgovoriBindingSource.DataSource = prikaz;
            }
        }

        private void dgvStudenti_SelectionChanged(object sender, EventArgs e)
        {
            Student selected = studentBindingSource.Current as Student;
            if (selected != null)
            {
                Console.WriteLine(selected.OIB);
                PrikaziUgovore(selected);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsplaceniUgovori ugovor = isplaceniUgovoriBindingSource.Current as IsplaceniUgovori;
            ReportForm forma = new ReportForm(ugovor);
            forma.ShowDialog();            
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            bool ugovoren = false, zaposlen = false;
            if (studentBindingSource.Current is Student selectedStudent)
            {
                using (var db = new RadniSatiEntities())
                {
                    foreach (var item in db.Ugovor)
                    {
                        if (item.Student == selectedStudent.RadnikId)
                        {
                            ugovoren = true;
                            foreach (var itemClosed in db.IsplaceniUgovori)
                            {
                                if (itemClosed.OIB == selectedStudent.OIB)
                                {
                                    zaposlen = true;
                                }
                            }
                        }
                    }
                    if (zaposlen)
                    {
                        MessageBox.Show("Student je već bio zaposlen, nije ga moguće obrisati!");
                    }
                    else
                    {
                        if (ugovoren)
                        {
                            MessageBox.Show("Molimo, otkažite sve otvorene ugovore studenta!");
                            Ugovori forma = new Ugovori(korisnik);
                            forma.ShowDialog();
                        }
                        else
                        {
                            DialogResult brisanje = MessageBox.Show("Jeste li sigurni da želite obrisati studenta "+selectedStudent.Ime+" "+selectedStudent.Prezime+"?", "Upozorenje", MessageBoxButtons.YesNo);
                            if (brisanje == DialogResult.Yes)
                            {
                                db.Student.Attach(selectedStudent);
                                db.Student.Remove(selectedStudent);
                                db.SaveChanges();
                            }
                        }
                    }
                }
                PrikaziStudente();
            }
        }

        private void btnGraf_Click(object sender, EventArgs e)
        {
            Student selected = studentBindingSource.Current as Student;
            Grafikon forma = new Grafikon(selected);
            forma.Text = "Praćenje rada za studenta: " + selected.Ime + " " + selected.Prezime;
            forma.ShowDialog();
        }
    }
}
