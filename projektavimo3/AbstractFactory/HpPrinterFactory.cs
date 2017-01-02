using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projektavimo3.Observer;

namespace projektavimo3.AbstractFactory
{
    public class HpPrinterFactory : PrinterFactory
    {
        public InkCartridge createInkCartrige()
        {
            return new Hp301();
        }

        public Printer createPrinter(string item)
        {
            if(item == "HpM225dw")
            {
                return new HpM225dw();
            }
            else if(item == "HpEnvy4507"){
                return new HpEnvy4507();
            }
            else
            {
                return null;
            }
        }
    }
}
