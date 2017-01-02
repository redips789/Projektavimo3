using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektavimo3.Observer
{
    public interface InkCartridge
    {
        double getQuantity();

        void setQuantity(double quantity);

        string getColor();

        void setColor(string value);

        void addObserver(InkCartridgeObserver observer);
    }
}
