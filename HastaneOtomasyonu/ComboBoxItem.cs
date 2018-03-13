using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public class ComboBoxItem
    {
        string displayValue;
        string hiddenValue;


        public ComboBoxItem(string d, string h)
        {
            displayValue = d;
            hiddenValue = h;
        }

        public string HiddenValue
        {
            get
            {
                return hiddenValue;
            }
        }

        public override string ToString()
        {
            return displayValue;
        }
    }

}
