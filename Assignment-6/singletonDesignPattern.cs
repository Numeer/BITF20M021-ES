using System;
public sealed class Singleton
{
    private static Singleton instance;
    private static object obj = new object();

    private Singleton() { }

    public static Singleton GetInstance()
    {
        lock(obj) // lock so new threat don't request while initialization of current threat
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
        }
        return instance;
    }

    public void SomeMethod()
    {
        Console.WriteLine("Executing SomeMethod in Singleton instance");
    }
}

public sealed class Singleton2
    {
        private static Singleton2 instance;

        private Singleton2() { }

        public static Singleton2 GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton2();
            }
            return instance;
        }

        public void SomeMethod()
        {
            Console.WriteLine("Executing SomeMethod in Singleton2 instance");
        }
    }


public interface IProduct
{
    void DisplayInfo();
}

public class ConcreteProductA : IProduct
{
    public void DisplayInfo()
    {
        Console.WriteLine("This is ConcreteProductA");
    }
}

public class ConcreteProductB : IProduct
{
    public void DisplayInfo()
    {
        Console.WriteLine("This is ConcreteProductB");
    }
}

public abstract class Creator
{
    public abstract IProduct FactoryMethod();
}

public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("------------------------1--------------------------");
        Singleton instance1 = Singleton.GetInstance();
        Singleton instance2 = Singleton.GetInstance();
        instance1.SomeMethod();
        instance2.SomeMethod();

        Singleton2 instance11 = Singleton2.GetInstance();
        Singleton2 instance12= Singleton2.GetInstance();
        instance11.SomeMethod();
        instance12.SomeMethod();

        Console.WriteLine("------------------------2--------------------------");
        Creator creatorA = new ConcreteCreatorA();
        IProduct productA = creatorA.FactoryMethod();
        productA.DisplayInfo();

        Creator creatorB = new ConcreteCreatorB();
        IProduct productB = creatorB.FactoryMethod();
        productB.DisplayInfo();
    }
}