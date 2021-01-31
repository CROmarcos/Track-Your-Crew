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
    public partial class DodajRadnoMjesto : Form
    {
        private RadnoMjesto selectedRM;
        private const string emptyForm = "__________";
        public decimal CijenaRadnogSata { get; set; }

        public DodajRadnoMjesto()
        {
            InitializeComponent();
        }

        public DodajRadnoMjesto(RadnoMjesto rm)
        {
            InitializeComponent();
            selectedRM = rm;
        }

        private void DodajRadnoMjesto_Load(object sender, EventArgs e)
        {
            if (selectedRM == null)
            {
                lbRadnoMjesto.Text = emptyForm;
                tbOpisPosla.Text = "";
                CijenaRadnogSata = 0;
                lbRadniSat.Text = "00,00 kn";
            }
            else
            {
                lbRadnoMjesto.Text = selectedRM.NazivRadnogMjesta;
                tbOpisPosla.Text = selectedRM.OpisRadnogMjesta;
                CijenaRadnogSata = selectedRM.CijenaRadnogSata;
                lbRadniSat.Text = selectedRM.CijenaRadnogSata.ToString() + " kn";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            InputForm forma = new InputForm();
            forma.ShowDialog();
            if (forma.TextValue != "")
            {
                lbRadnoMjesto.Text = forma.TextValue;
            }
            else if (forma.EnterValue)
            {
                lbRadnoMjesto.Text = emptyForm;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            tbOpisPosla.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OibForm forma = new OibForm(2);
            forma.ShowDialog();
            if (forma.TextValue != "")
            {
                CijenaRadnogSata = Convert.ToDecimal(forma.TextValue);
                lbRadniSat.Text = forma.TextValue + " kn";
            }
        }
        private void btnUnesi_Click(object sender, EventArgs e)
        {
            using (var db = new RadniSatiEntities())
            {
                if (selectedRM == null)
                {
                    if(lbRadnoMjesto.Text!= emptyForm && CijenaRadnogSata != 0)
                    {
                        RadnoMjesto rm = new RadnoMjesto()
                        {
                            NazivRadnogMjesta = lbRadnoMjesto.Text,
                            OpisRadnogMjesta = tbOpisPosla.Text,
                            CijenaRadnogSata = CijenaRadnogSata
                        };
                        db.RadnoMjesto.Add(rm);
                        db.SaveChanges();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Niste ispravno unijeli podatke", "Upozorenje", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    if (lbRadnoMjesto.Text != emptyForm && CijenaRadnogSata != 0)
                    {
                        db.RadnoMjesto.Attach(selectedRM);
                        selectedRM.NazivRadnogMjesta = lbRadnoMjesto.Text;
                        selectedRM.OpisRadnogMjesta = tbOpisPosla.Text;
                        selectedRM.CijenaRadnogSata = CijenaRadnogSata;
                        db.SaveChanges();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Niste ispravno unijeli podatke", "Upozorenje", MessageBoxButtons.OK);
                    }
                }
            }
        }
    }
}
