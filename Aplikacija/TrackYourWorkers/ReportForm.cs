using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackYourWorkers
{
    public partial class ReportForm : Form
    {
        private IsplaceniUgovori srcUgovor;
        public ReportForm(IsplaceniUgovori ugovor)
        {
            InitializeComponent();
            srcUgovor = ugovor;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            IsplaceniUgovoriBindingSource.DataSource = srcUgovor;
            this.reportViewer1.RefreshReport();
        }

        private void btnSpremiPDF_Click(object sender, EventArgs e)
        {
            string korisnik = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last();
            string fileName = srcUgovor.Student.Replace(" ", "_") + "_" + srcUgovor.Mjesec.Replace(@"/", "_");
            string path = @"C:\Users\" + korisnik + @"\downloads\" + fileName + ".pdf";
            SavePDF(reportViewer1, path);
            Close();
        }

        public void SavePDF(ReportViewer viewer, string savePath)
        {
            byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");
            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
        }
    }
}
