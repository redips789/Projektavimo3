using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projektavimo3.Observer;

namespace projektavimo3.AbstractFactory
{
    class MX925 : Printer
    {
        private InkCartridge inkCartridge;
        public InkCartridge getInkCartrige()
        {
            return inkCartridge;
        }

        public void print()
        {
            Console.WriteLine("Spausdina MX925");
        }

        public void setInkCartridge(InkCartridge cartridge)
        {
            this.inkCartridge = cartridge;
        }
    }
}
