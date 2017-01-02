using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projektavimo3.Observer;

namespace projektavimo3.AbstractFactory
{
    class HpEnvy4507 : Printer
    {
        private InkCartridge inkCartrige;
        public InkCartridge getInkCartrige()
        {
            return inkCartrige;
        }

        public void print()
        {
            Console.WriteLine("Spausdina HpEnvy4507");
        }

        public void setInkCartridge(InkCartridge cartridge)
        {
            this.inkCartrige = cartridge;
        }

    }
}
