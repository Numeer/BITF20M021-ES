using System;
namespace PrototypeDesignPattern
{
    // Prototype interface
    public abstract class Prototype
    {
        public abstract Prototype Clone();
    }
    
    // Concrete prototype
    public class Car :Prototype
    {
        public string Make {get; set;}
        public string Model {get; set;}
        public int Year {get; set;}
        public List<String> options {get; set;}

        public Car(string make, string model, int year, List<String>options)
        {
            Make = make;
            Model = model;
            Year = year;
            this.options = options;
        }

        public override Prototype Clone()
        {
            return new Car(Make, Model, Year, new List<String>(options));
        }

        public override string ToString()
        {
            return $"Make: {Make}, Model: {Model}, Year: {Year}, Options: {String.Join(",",options)}";
        }
    }
    
    // Prototype interface
    public interface ICloneablePrototype
    {
        ICloneablePrototype Clone();
    }

    // Concrete prototype
    public class ConcretePrototype : ICloneablePrototype, ICloneable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ConcretePrototype(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public ICloneablePrototype Clone()
        {
            return (ICloneablePrototype)MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------1--------------------------");
            List<String> options = new List<String>()
            {
                "Sunroof","Navigations","Leather Seats"
            };
            Car c1 = new Car("Ford","Mustang",2822,options);
            Car c2 = c1.Clone() as Car;

            Console.WriteLine("Original");
            Console.WriteLine(c1);
            Console.WriteLine("Cloned");
            Console.WriteLine(c2);

            Console.WriteLine("------------------------2--------------------------");
            ConcretePrototype original = new ConcretePrototype(1, "Original");
            ConcretePrototype cloned = (ConcretePrototype)original.Clone();
            cloned.Name = "Cloned";
            Console.WriteLine(original);
            Console.WriteLine(cloned);

        }
    }
}