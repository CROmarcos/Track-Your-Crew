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
    public partial class OibForm : Form
    {
        //String je da ne briše nule s početka
        public string TextValue { get; set; }

        //0 - OIB, 1 - Telefon, 2 - Radni sat
        private int Broj { get; set; }

        //Služi da se kod ponovnog unosa vrijednosti pritiskom na ESC ne obriše stara vrijednost.
        public bool EnterValue { get; set; }

        public OibForm()
        {
            InitializeComponent();
            Broj = 0;
        }

        public OibForm(int broj)
        {
            InitializeComponent();
            Broj = broj;
        }

        private void OibForm_Load(object sender, EventArgs e)
        {
            TextValue = "";
            EnterValue = false;
            if (Broj == 1)
            {
                pictureBox1.Visible = true;
                tbInput.TextAlign = HorizontalAlignment.Right;
            }
            else
            {
                pictureBox1.Visible = false;
                tbInput.TextAlign = HorizontalAlignment.Center;
            }
        }

        private void OibForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                EnterValue = false;
                TextValue = "";
                Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                TextValue = tbInput.Text.ToString();
                EnterValue = true;
                if (Broj == 0)
                {
                    if (TextValue.Length == 11)
                    {
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("OIB mora imati točno 11 znakova!");
                    }
                }
                else
                {
                    Close();
                }
            }
        }

        private void tbInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Broj == 2)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == ','))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
