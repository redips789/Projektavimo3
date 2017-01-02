using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektavimo3.Observer
{
    public interface InkCartridgeObserver
    {
        void notify(InkCartridge inkCartrige);
    }
}
