using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackYourWorkers
{
    public partial class DodajStudenta : Form
    {
        private Student selectedStudent;
        private const string emptyForm = "__________";

        public DodajStudenta()
        {
            InitializeComponent();
        }

        public DodajStudenta(Student student)
        {
            InitializeComponent();
            selectedStudent = student;
        }
        private void DodajStudenta_Load(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                FillTheCombo();
                labelIme.Text = emptyForm;
                labelPrezime.Text = emptyForm;
                labelOib.Text = emptyForm;
                labelFakultet.Text = emptyForm;
                labelMobitel.Text = emptyForm;
                labelEmail.Text = emptyForm;
            }
            else
            {
                labelOib.Visible = false;
                cbGodiste.Visible = false;
                labelIme.Text = selectedStudent.Ime;
                labelPrezime.Text = selectedStudent.Prezime;
                labelFakultet.Text = selectedStudent.Fakultet;
                labelMobitel.Text = selectedStudent.Mobitel;
                labelEmail.Text = selectedStudent.Email;
                label3.Text = "OIB nije moguće promijeniti!";
                label4.Text = "Godinu rođenja nije moguće promijeniti!";
            }
        }


        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new RadniSatiEntities())
                {
                    if (selectedStudent == null)
                    {
                        if (labelIme.Text != emptyForm && labelPrezime.Text != emptyForm && labelOib.Text != emptyForm && labelFakultet.Text != emptyForm && labelMobitel.Text != emptyForm && labelEmail.Text != emptyForm && cbGodiste.SelectedItem != null)
                        {
                            Student student = new Student
                            {
                                Ime = labelIme.Text,
                                Prezime = labelPrezime.Text,
                                OIB = labelOib.Text,
                                Fakultet = labelFakultet.Text,
                                GodinaRodjenja = Convert.ToInt32(cbGodiste.SelectedItem.ToString()),
                                Mobitel = labelMobitel.Text,
                                Email = labelEmail.Text
                            };
                            db.Student.Add(student);
                            db.SaveChanges();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Niste ispravno unijeli podatke!", "Upozorenje", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        if (labelIme.Text != emptyForm && labelPrezime.Text != emptyForm && labelFakultet.Text != emptyForm && labelMobitel.Text != emptyForm && labelEmail.Text != emptyForm)
                        {
                            db.Student.Attach(selectedStudent);
                            selectedStudent.Ime = labelIme.Text;
                            selectedStudent.Prezime = labelPrezime.Text;
                            selectedStudent.Fakultet = labelFakultet.Text;
                            selectedStudent.Mobitel = labelMobitel.Text;
                            selectedStudent.Email = labelEmail.Text;
                            db.SaveChanges();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Niste ispravno unijeli podatke!", "Upozorenje", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Već postoji student s tim OIB-om.", "Pogreška", MessageBoxButtons.OK);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            InputForm forma = new InputForm();
            forma.ShowDialog();
            if (forma.TextValue != "")
            {
                labelIme.Text = forma.TextValue;
            }
            else if (forma.EnterValue)
            {
                labelIme.Text = emptyForm;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            InputForm forma = new InputForm();
            forma.ShowDialog();
            if (forma.TextValue != "")
            {
                labelPrezime.Text = forma.TextValue;
            }
            else if (forma.EnterValue)
            {
                labelPrezime.Text = emptyForm;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OibForm forma = new OibForm();
            forma.ShowDialog();
            if (forma.TextValue != "")
            {
                labelOib.Text = forma.TextValue;
            }
            else if (forma.EnterValue)
            {
                labelOib.Text = emptyForm;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            cbGodiste.Focus();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            InputForm forma = new InputForm();
            forma.ShowDialog();
            if (forma.TextValue != "")
            {
                labelFakultet.Text = forma.TextValue;
            }
            else if (forma.EnterValue)
            {
                labelFakultet.Text = emptyForm;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            OibForm forma = new OibForm(1);
            forma.ShowDialog();
            if (forma.TextValue != "")
            {
                labelMobitel.Text = forma.TextValue;
            }
            else if (forma.EnterValue)
            {
                labelMobitel.Text = emptyForm;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            InputForm forma = new InputForm();
            forma.ShowDialog();
            if (forma.TextValue != "")
            {
                labelEmail.Text = forma.TextValue;
            }
            else if (forma.EnterValue)
            {
                labelEmail.Text = emptyForm;
            }
        }

        private void FillTheCombo()
        {
            for (int i = 1980; i <= 2002; i++)
            {
                cbGodiste.Items.Add(i);
            }
        }
    }
}
