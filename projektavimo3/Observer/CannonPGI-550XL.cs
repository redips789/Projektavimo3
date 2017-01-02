using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektavimo3.Observer
{
    public class CannonPGI_550XL : InkCartridge
    {
        private string color = "Nespalvotas";
        private double quantity = 120;
        private List<InkCartridgeObserver> observers = new List<InkCartridgeObserver>();
        public void addObserver(InkCartridgeObserver observer)
        {
            observers.Add(observer);
        }

        public void notifyObserver()
        {
            foreach (InkCartridgeObserver observer in observers)
            {
                observer.notify(this);
            }
        }

        public string getColor()
        {
            return color;
        }

        public double getQuantity()
        {
            return quantity;
        }

        public void setColor(string value)
        {
            this.color = value;
            notifyObserver();
        }

        public void setQuantity(double quantity)
        {
            this.quantity = quantity;
            notifyObserver();
        }
    }
}
