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
        public Pocetna()
        {
            InitializeComponent();
        }

        private void btnStudenti_Click(object sender, EventArgs e)
        {
            Studenti forma = new Studenti();
            forma.ShowDialog();
        }

        private void btnRadnaMjesta_Click(object sender, EventArgs e)
        {
            RadnaMjesta forma = new RadnaMjesta();
            forma.ShowDialog();
        }

        private void btnUgovori_Click(object sender, EventArgs e)
        {
            Ugovori forma = new Ugovori();
            forma.ShowDialog();
        }
    }
}
