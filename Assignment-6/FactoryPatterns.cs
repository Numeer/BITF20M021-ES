using System;
namespace FactoryPatterns
{
    public interface ICar
    {
        void Start();
    }

    public class SixSeaterCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("SixSeaterCar started");
        }
    }

    public class FourSeaterCar : ICar
    {
        public void Start()
        {
            Console.WriteLine("FourSeaterCar started");
        }
    }

    public class CarFactory
    {
        public ICar GetCar(string CarType)
        {
            switch(CarType)
            {
                case "SixSeaterCar":
                    return new SixSeaterCar();
                case "FourSeaterCar":
                    return new FourSeaterCar();
            }
            return null;
        }
    }
    
    // Interface for logger
    public interface ILogger
    {
        void Log(string message);
    }

    // Concrete classes implementing ILogger
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to file: {message}");
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to console: {message}");
        }
    }

    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logging to database: {message}");
        }
    }

    // Factory class to create loggers
    public class LoggerFactory
    {
        // Factory method
        public ILogger GetLogger(string loggerType)
        {
            switch (loggerType.ToLower())
            {
                case "file":
                    return new FileLogger();
                case "console":
                    return new ConsoleLogger();
                case "database":
                    return new DatabaseLogger();
                default:
                    throw new ArgumentException("Invalid logger type");
            }
        }
    }

    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("------------------------1--------------------------");

            CarFactory carFactory = new CarFactory();
            ICar sixSeaterCar = carFactory.GetCar("SixSeaterCar");
            ICar fourSeaterCar = carFactory.GetCar("FourSeaterCar");
            sixSeaterCar.Start();
            fourSeaterCar.Start();

            Console.WriteLine("------------------------2--------------------------");

            LoggerFactory loggerFactory = new LoggerFactory();
            ILogger fileLogger = loggerFactory.GetLogger("file");
            fileLogger.Log("File logging...");

            ILogger consoleLogger = loggerFactory.GetLogger("console");
            consoleLogger.Log("Console logging...");

            ILogger databaseLogger = loggerFactory.GetLogger("database");
            databaseLogger.Log("Database logging...");

        }
    }
}