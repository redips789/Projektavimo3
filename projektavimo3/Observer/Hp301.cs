using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektavimo3.Observer
{
    class Hp301 : InkCartridge
    {
        private string color = "spalvotas";
        private double quantity = 100;
        private List<InkCartridgeObserver> observers = new List<InkCartridgeObserver>();
        public void addObserver(InkCartridgeObserver observer)
        {
            observers.Add(observer);
        }

        public void notifyObserver()
        {
            foreach(InkCartridgeObserver observer in observers)
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
