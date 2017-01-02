using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projektavimo3.AbstractFactory;
using projektavimo3.Observer;

namespace projektavimo3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrinterFactory hpPrinterFactory = FactoryProducer.getPrinterFactory("Hp");
            Printer hpEnvy4507 = hpPrinterFactory.createPrinter("HpEnvy4507");
            hpEnvy4507.print();
            Printer hpM225dw = hpPrinterFactory.createPrinter("HpM225dw");
            hpM225dw.print();
            PrinterFactory cannonPrinterFactory = FactoryProducer.getPrinterFactory("Cannon");
            Printer mx925 = cannonPrinterFactory.createPrinter("MX925");
            mx925.print();
            Printer ix6850 = cannonPrinterFactory.createPrinter("IX6850");
            ix6850.print();
            ix6850.setInkCartridge(cannonPrinterFactory.createInkCartrige());
            ix6850.getInkCartrige().addObserver(new InkCartridgeChangesDisplay());
            ix6850.getInkCartrige().setColor("red");

            Console.ReadLine();
        }
    }
}
