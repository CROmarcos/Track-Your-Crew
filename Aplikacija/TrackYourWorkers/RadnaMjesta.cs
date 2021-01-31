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
    public partial class RadnaMjesta : Form
    {
        public RadnaMjesta()
        {
            InitializeComponent();
        }

        private void RadnaMjesta_Load(object sender, EventArgs e)
        {
            PrikaziRadnaMjesta();
            dgvRadnoMjesto.Columns[2].Width = 300;
        }

        private void PrikaziRadnaMjesta()
        {
            BindingList<RadnoMjesto> popisRadnihMjesta = null;
            using (var db = new RadniSatiEntities())
            {
                popisRadnihMjesta = new BindingList<RadnoMjesto>(db.RadnoMjesto.ToList());
            }
            radnoMjestoBindingSource.DataSource = popisRadnihMjesta;
        }

        private void btnUnesiRM_Click(object sender, EventArgs e)
        {
            dgvRadnoMjesto.ClearSelection();
            DodajRadnoMjesto forma = new DodajRadnoMjesto();
            forma.ShowDialog();
            PrikaziRadnaMjesta();
        }

        private void btnIzmijeniRM_Click(object sender, EventArgs e)
        {
            RadnoMjesto selectedRM = radnoMjestoBindingSource.Current as RadnoMjesto;
            if (selectedRM != null)
            {
                DodajRadnoMjesto forma = new DodajRadnoMjesto(selectedRM);
                forma.ShowDialog();
                PrikaziRadnaMjesta();
            }
        }
    }
}
