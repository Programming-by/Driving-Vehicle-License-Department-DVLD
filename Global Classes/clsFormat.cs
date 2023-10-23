using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DVLDClasses
{
    public class clsFormat
    {

        public string DateToShort(DateTime Dt1)
        {
            return Dt1.ToString("dd/MMM/YYYY");
        }

    }
}
