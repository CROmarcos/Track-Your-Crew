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
    public partial class InputForm : Form
    {
        public string TextValue { get; set; }
        public bool EnterValue { get; set; }
        public InputForm()
        {
            InitializeComponent();
            tbInput.TextAlign = HorizontalAlignment.Center;
            TextValue = "";
            EnterValue = false;
        }

        private void InputForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TextValue = tbInput.Text.ToString();
                    EnterValue = true;
                }
                Close();
            }
        }

        private void tbInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
