using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projektavimo3.Observer;

namespace projektavimo3.AbstractFactory
{
    class HpM225dw : Printer
    {
        private InkCartridge inkCartridge;
        public InkCartridge getInkCartrige()
        {
            return inkCartridge;
        }

        public void print()
        {
            Console.WriteLine("Spausdina HpM225dw");
        }

        public void setInkCartridge(InkCartridge cartridge)
        {
            this.inkCartridge = cartridge;
        }
    }
}
