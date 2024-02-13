using Laiterekisteri2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laiterekisteri2
{
    // Base class for devices
    class Device
    {
        // Fields
        // ------
        string identity = "Uusi laite";
        string dateBought = "1.1.2000";
        double price = 0.00d;
        int warranty = 12;

        // Properties
        // ----------
        public string Identity
        {
            get { return identity; }
            set { identity = value; }

        }

        public string DateBought
        {
            get { return dateBought; }
            set { dateBought = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Warranty
        {
            get { return warranty; }
            set { warranty = value; }
        }

        // Constructions
        // -------------
        public Device()
        {

        }
        // A constructor with one argument
        public Device(string identity)
        {
            this.identity = identity;
        }

        // Another constructor with all arguments
        public Device(string indentity, string dateBought, double price, int warranty)
        {
            this.identity += indentity;
            this.dateBought = dateBought;
            this.price = price;
            this.warranty = warranty;
        }

        // Other methods
        // -------------
    }

    // Class for computers, inherits Device class
    class Computer : Device
    {

    }

    // Class for computers, inherits Device class
    class SmartPhone : Device
    {
        // Fields

        // Properties

        // Constructions

        // Other methods
    }

    // Class for computers, inherits Device class
    class Tablet : Device
    {
        // Fields

        // Properties

        // Constructions

        // Other methods
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Let's create am test object from the Device class with default constructor ( 0 parameters)
            Device device1 = new Device();
            Console.WriteLine(device1.Identity);

            // Let´s create another device with identity parameter
            Device device2 = new Device("Toinen laite");
            Console.WriteLine(device2.Identity);

            // Let´s create one more device with all parameters
            Device device3 = new Device("Kolmas kone", "8.2.2024", 150.00d, 36);

            Console.WriteLine(device3.Identity);
            Console.WriteLine(device3.Price);
            
            
            Console.ReadLine();
        }
    }
}
