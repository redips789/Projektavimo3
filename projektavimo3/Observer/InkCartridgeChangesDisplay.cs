using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektavimo3.Observer
{
    class InkCartridgeChangesDisplay :InkCartridgeObserver
    {
        public void notify(InkCartridge inkCartridge)
        {
            Console.WriteLine("Ink Cartridge properties have changed\n" +
                              "    New color: " + inkCartridge.getColor() + "\n" +
                              "    New quantity: " + inkCartridge.getQuantity() + "\n");
        }
    }
}
