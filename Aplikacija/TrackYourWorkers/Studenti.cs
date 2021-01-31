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
        public Studenti()
        {
            InitializeComponent();
        }

        private void Studenti_Load(object sender, EventArgs e)
        {
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
            BindingList<IsplaceniUgovori> lista = null;
            BindingList<IsplaceniUgovori> prikaz = new BindingList<IsplaceniUgovori>();
            using (var db = new RadniSatiEntities())
            {
                db.Student.Attach(student);
                lista = new BindingList<IsplaceniUgovori>(db.IsplaceniUgovori.ToList());
            }
            foreach (var item in lista)
            {
                if (item.OIB == student.OIB)
                {
                    prikaz.Add(item);
                }
            }
            isplaceniUgovoriBindingSource.DataSource = prikaz;
        }

        private void dgvStudenti_SelectionChanged(object sender, EventArgs e)
        {
            Student selected=studentBindingSource.Current as Student;
            if (selected != null)
            {
                PrikaziUgovore(selected);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IsplaceniUgovori ugovor = isplaceniUgovoriBindingSource.Current as IsplaceniUgovori;
            ReportForm forma = new ReportForm(ugovor);
            forma.ShowDialog();            
        }
    }
}
