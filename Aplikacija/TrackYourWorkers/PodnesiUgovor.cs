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
    public partial class PodnesiUgovor : Form
    {
        private Ugovor ugovor;
        private Student student;
        private RadnoMjesto rm;
        private double radniSat;

        public PodnesiUgovor(Ugovor selected)
        {
            InitializeComponent();
            ugovor = selected;
        }

        private void PodnesiUgovor_Load(object sender, EventArgs e)
        {
            using (var db = new RadniSatiEntities())
            {
                foreach (var item in db.Student)
                {
                    if (ugovor.Student == item.RadnikId)
                    {
                        student = item;
                    }
                }
                foreach (var item in db.RadnoMjesto)
                {
                    if (ugovor.RadnoMjesto == item.RadnoMjestoId)
                    {
                        rm = item;
                        radniSat = Convert.ToDouble(item.CijenaRadnogSata);
                    }
                }
            }
            lbStudent.Text = "Ugovor za studenta: " + student.Ime + " " + student.Prezime + " (OIB: " + student.OIB + ")";
            lbMjesec.Text = "Za mjesec: " + ugovor.Mjesec;
            lbRM.Text = "Radno mjesto: " + rm.NazivRadnogMjesta;
            lbIznos.Text = "Ukupan iznos:";
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            lbIznos.Text = "Ukupan iznos: " + (Convert.ToInt32(tbRS.Text) * radniSat).ToString() + " kn";
        }

        private void btnPodnesi_Click(object sender, EventArgs e)
        {
            if (tbRS.Text != null)
            {
                using (var db = new RadniSatiEntities())
                {
                    db.Ugovor.Attach(ugovor);
                    ugovor.BrojRadnihSati = Convert.ToInt32(tbRS.Text);
                    db.SaveChanges();
                    Close();
                }
            }
        }

        private void tbRS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
