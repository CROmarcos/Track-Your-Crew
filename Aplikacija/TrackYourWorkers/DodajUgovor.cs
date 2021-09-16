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
    public partial class DodajUgovor : Form
    {
        private BindingList<Student> listaStudenata;
        private BindingList<RadnoMjesto> listaRM;
        public DodajUgovor()
        {
            InitializeComponent();
        }

        private void DodajUgovor_Load(object sender, EventArgs e)
        {
            FillTheCombo();
        }

        private void FillTheCombo()
        {
            listaStudenata = null;
            listaRM = null;
            using (var db = new RadniSatiEntities())
            {
                listaStudenata = new BindingList<Student>(db.Student.ToList());
                listaRM = new BindingList<RadnoMjesto>(db.RadnoMjesto.ToList());
            }
            foreach (Student i in listaStudenata)
            {
                ComboBoxItem item = new ComboBoxItem
                {
                    Value = i.RadnikId,
                    Text = i.Ime + ' ' + i.Prezime
                };
                cbStudent.Items.Add(item);
            }
            foreach (RadnoMjesto i in listaRM)
            {
                ComboBoxItem item = new ComboBoxItem
                {
                    Value = i.RadnoMjestoId,
                    Text = i.NazivRadnogMjesta
                };
                cbRadnoMjesto.Items.Add(item);
            }
            dtp.Value = DateTime.Today;
        }

        private void btnOtvori_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new RadniSatiEntities())
                {
                    if (cbStudent.SelectedItem != null && cbRadnoMjesto.SelectedItem != null)
                    {
                        Ugovor ugovor = new Ugovor
                        {
                            Student = (cbStudent.SelectedItem as ComboBoxItem).GetValue(),
                            RadnoMjesto = (cbRadnoMjesto.SelectedItem as ComboBoxItem).GetValue(),
                            DatumOtvaranja = dtp.Value
                        };
                        db.Ugovor.Add(ugovor);
                        db.SaveChanges();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Niste ispravno unijeli podatke!", "Upozorenje", MessageBoxButtons.OK);
                    }
                }
            }
            catch (DbUpdateException)
            {
                MessageBox.Show("Student " + cbStudent.SelectedItem.ToString() + " već ima ugovor za taj mjesec!", "Upozorenje", MessageBoxButtons.OK);
            }
        }
    }
}
