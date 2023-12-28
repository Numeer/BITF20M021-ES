using System;
namespace AbstractFactoryPattern
{
    public interface ICar //abstract product
    {
        void Manufacture();
    }
    
    public interface IBike
    {
        void Manufacture();
    }

    public class TeslaAutoCar : ICar //concrete product for TESLA
    {
        public void Manufacture()
        {
            Console.WriteLine("TeslaAutoCar Manufactured");
        }
    }

    public class TeslaBike:IBike
    {
        public void Manufacture()
        {
            Console.WriteLine("TeslaBike Manufactured");
        }
    }
    
     public class TataCar : ICar //concrete product for TATA
    {
        public void Manufacture()
        {
            Console.WriteLine("TataCar Manufactured");
        }
    }
    
    public class TataBike:IBike
    {
        public void Manufacture()
        {
            Console.WriteLine("TataBike Manufactured");
        }
    }

    public interface IVehicleFactory //abstract factory interface
    {
        ICar CreateCar();
        IBike CreateBike();
    }

    class TeslaFactory:IVehicleFactory //concrete factory for tesla
    {
        public ICar CreateCar()
        {
            return new TeslaAutoCar();
        }
        public IBike CreateBike()
        {
            return new TeslaBike();
        }
    }

    class TataFactory : IVehicleFactory // concrete factory for tata
    {
        public ICar CreateCar()
        {
            return new TataCar();
        }
        public IBike CreateBike()
        {
            return new TataBike();
        }
    }

    // Abstract product interfaces
    public interface IButton
    {
        void Paint();
    }

    public interface ITextBox
    {
        void Display();
    }

    // Concrete product classes for Windows GUI
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a Windows style button");
        }
    }

    public class WindowsTextBox : ITextBox
    {
        public void Display()
        {
            Console.WriteLine("Displaying a Windows style textbox");
        }
    }

    // Concrete product classes for Mac GUI
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Rendering a Mac style button");
        }
    }

    public class MacTextBox : ITextBox
    {
        public void Display()
        {
            Console.WriteLine("Displaying a Mac style textbox");
        }
    }

    // Abstract factory interface
    public interface IGUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }

    // Concrete factory for Windows GUI elements
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }

    // Concrete factory for Mac GUI elements
    public class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
    
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("------------------------1--------------------------");

           IVehicleFactory vehicleFactory;
            string preference = "Tata ";

            if (preference == "Tesla")
            {
                vehicleFactory = new TeslaFactory();
            }
            else
            {
                vehicleFactory = new TataFactory();
            }
            ICar car = vehicleFactory.CreateCar();
            IBike bike = vehicleFactory.CreateBike();

            car.Manufacture();
            bike.Manufacture();

            Console.WriteLine("------------------------2--------------------------");
            // Creating a Windows GUI factory
            IGUIFactory windowsFactory = new WindowsFactory();

            // Creating Windows style button and textbox
            IButton windowsButton = windowsFactory.CreateButton();
            ITextBox windowsTextBox = windowsFactory.CreateTextBox();

            windowsButton.Paint();
            windowsTextBox.Display();

            // Creating a Mac GUI factory
            IGUIFactory macFactory = new MacFactory();

            // Creating Mac style button and textbox
            IButton macButton = macFactory.CreateButton();
            ITextBox macTextBox = macFactory.CreateTextBox();

            macButton.Paint();
            macTextBox.Display();

        }
    }
}