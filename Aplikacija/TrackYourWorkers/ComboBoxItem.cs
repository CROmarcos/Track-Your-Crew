using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackYourWorkers
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        public int GetValue()
        {
            return Value;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
