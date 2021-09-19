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
    public partial class Grafikon : Form
    {
        Student student;
        struct Stupac
        {
            public string mjesec;
            public int vrijednost;
        }
        public Grafikon(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void Grafikon_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            chart1.ChartAreas[0].AxisX.Title = "Mjesec";
            chart1.ChartAreas[0].AxisY.Title = "Sati odrađeno";
            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 12;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 160;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 20;
            chart1.Series["Kretanje odrađenih sati kroz godinu"].IsValueShownAsLabel = true;
            comboBox1.Items.Add(2019);
            comboBox1.Items.Add(2020);
            comboBox1.Items.Add(2021);
            comboBox1.SelectedItem = 2021;
            ucitajGraf();
        }

        private void ucitajGraf()
        {
            List<Stupac> stupci = new List<Stupac>();
            BindingList<IsplaceniUgovori> lista = null;
            using (var db = new RadniSatiEntities())
            {
                lista = new BindingList<IsplaceniUgovori>();
                foreach (var item in db.IsplaceniUgovori)
                {
                    if (student.OIB == item.OIB && item.Mjesec.EndsWith(comboBox1.SelectedItem.ToString()))
                    {
                        lista.Add(item);
                    }
                }
            }
            for (int i = 1; i <= 12; i++)
            {
                Stupac stupac = new Stupac();
                stupac.mjesec = nazivMjeseca(i);
                stupac.vrijednost = 0;
                foreach (var item in lista)
                {
                    if (item.Mjesec.StartsWith(i.ToString() + "/"))
                    {
                        stupac.vrijednost = Convert.ToInt32(item.BrojRadnihSati);
                    }
                }
                stupci.Add(stupac);
            }
            foreach (var item in stupci)
            {
                chart1.Series["Kretanje odrađenih sati kroz godinu"].Points.AddXY(item.mjesec, item.vrijednost);
            }
        }
        private string nazivMjeseca(int mjesec)
        {
            string naziv = "";
            switch (mjesec)
            {
                case 1:
                    naziv = "siječanj";
                    break;
                case 2:
                    naziv = "veljača";
                    break;
                case 3:
                    naziv = "ožujak";
                    break;
                case 4:
                    naziv = "travanj";
                    break;
                case 5:
                    naziv = "svibanj";
                    break;
                case 6:
                    naziv = "lipanj";
                    break;
                case 7:
                    naziv = "srpanj";
                    break;
                case 8:
                    naziv = "kolovoz";
                    break;
                case 9:
                    naziv = "rujan";
                    break;
                case 10:
                    naziv = "listopad";
                    break;
                case 11:
                    naziv = "studeni";
                    break;
                case 12:
                    naziv = "prosinac";
                    break;
                default:
                    naziv = "pogreška";
                    break;
            }
            return naziv;
        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            chart1.Series["Kretanje odrađenih sati kroz godinu"].Points.Clear();
            ucitajGraf();
        }
    }
}
