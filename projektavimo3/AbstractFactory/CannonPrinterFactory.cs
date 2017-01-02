using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projektavimo3.Observer;

namespace projektavimo3.AbstractFactory
{
    public class CannonPrinterFactory : PrinterFactory
    {
        public InkCartridge createInkCartrige()
        {
            return new CannonPGI_550XL();
        }

        public Printer createPrinter(string item)
        {
            if (item == "MX925")
            {
                return new MX925();
            }
            else if (item == "IX6850")
            {
                return new IX6850();
            }
            else
            {
                return null;
            }
        }
    }
}
