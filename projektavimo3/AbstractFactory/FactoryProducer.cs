using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektavimo3.AbstractFactory
{
    public class FactoryProducer
    {
        public static PrinterFactory getPrinterFactory(string factoryType)
        {
            if (factoryType == "Hp")
            {
                return new HpPrinterFactory();
            }
            else if (factoryType == "Cannon")
            {
                return new CannonPrinterFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
