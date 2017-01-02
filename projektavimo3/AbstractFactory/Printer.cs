﻿using projektavimo3.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektavimo3.AbstractFactory
{
    public interface Printer
    {
        void setInkCartridge(InkCartridge cartridge);

        InkCartridge getInkCartrige();
        void print();
    }
}
