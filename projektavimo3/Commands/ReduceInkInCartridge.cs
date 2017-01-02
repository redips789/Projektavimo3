using projektavimo3.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektavimo3.Commands
{
    public class ReduceInkInCartridge : Command,Revertable
    {
        private InkCartridge inkCartridge;

        private double amount;

        public ReduceInkInCartridge (InkCartridge inkCartridge, double amount)
        {
            this.inkCartridge = inkCartridge;
            this.amount = amount;
        }

        public void execute()
        {
            inkCartridge.setQuantity(inkCartridge.getQuantity() - amount);
        }

        public void undo()
        {
            inkCartridge.setQuantity(inkCartridge.getQuantity() + amount);
        }
    }
}
