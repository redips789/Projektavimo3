using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projektavimo3.Observer;

namespace projektavimo3.AbstractFactory
{
    class IX6850 : Printer
    {
        private InkCartridge inkCartridge;
        public InkCartridge getInkCartrige()
        {
            return inkCartridge;
        }

        public void print()
        {
            Console.WriteLine("Spausdina IX6850");
        }

        public void setInkCartridge(InkCartridge cartridge)
        {
            this.inkCartridge = cartridge;
        }
    }
}
