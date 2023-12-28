using System;

public class CellPhone
{
    private string os;
    private string processor;
    private string screenSize;
    private int battery;
    private int camera;

    public CellPhone(string os, string processor, string screenSize, int battery, int camera)
    {
        this.os = os;
        this.processor = processor;
        this.screenSize = screenSize;
        this.battery = battery;
        this.camera = camera;
    }

    public override string ToString()
    {
        return $"OS: {os}, Processor: {processor}, ScreenSize: {screenSize}, Battery: {battery}, Camera: {camera}";
    }
}

public class CellPhoneBuilder
{
    private string os;
    private string processor;
    private string screenSize;
    private int battery;
    private int camera;

    public void SetOs(string name)
    {
        os = name;
    }

    public void SetProcessor(string pro)
    {
        processor = pro;
    }

    public void SetScreenSize(string size)
    {
        screenSize = size;
    }

    public void SetBattery(int batt)
    {
        battery = batt;
    }

    public void SetCamera(int cam)
    {
        camera = cam;
    }

    public CellPhone GetPhone()
    {
        return new CellPhone(os, processor, screenSize, battery, camera);
    }
}

//product
public class Pizza
{
    public string Dough { get; set; }
    public string Sauce { get; set; }
    public string Topping { get; set; }

    public override string ToString()
    {
        return $"Dough: {Dough}, Sauce: {Sauce}, Topping: {Topping}";
    }
}

// Abstract builder
public interface IPizzaBuilder
{
    void BuildDough();
    void BuildSauce();
    void BuildTopping();
    Pizza GetPizza();
}

// Concrete builder
public class HawaiianPizzaBuilder : IPizzaBuilder
{
    private readonly Pizza _pizza = new Pizza();

    public void BuildDough()
    {
        _pizza.Dough = "Thin crust";
    }

    public void BuildSauce()
    {
        _pizza.Sauce = "Tomato sauce";
    }

    public void BuildTopping()
    {
        _pizza.Topping = "Ham and pineapple";
    }

    public Pizza GetPizza()
    {
        return _pizza;
    }
}

// Director class
public class PizzaDirector
{
    private readonly IPizzaBuilder _pizzaBuilder;

    public PizzaDirector(IPizzaBuilder pizzaBuilder)
    {
        _pizzaBuilder = pizzaBuilder;
    }

    public void ConstructPizza()
    {
        _pizzaBuilder.BuildDough();
        _pizzaBuilder.BuildSauce();
        _pizzaBuilder.BuildTopping();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------------------1--------------------------");
        CellPhoneBuilder phone = new CellPhoneBuilder();
        phone.SetOs("Android");
        phone.SetProcessor("Quantom");
        phone.SetBattery(4500);

        CellPhone builtPhone = phone.GetPhone();
        Console.WriteLine(builtPhone);

        Console.WriteLine("------------------------2--------------------------");
        IPizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
        PizzaDirector director = new PizzaDirector(hawaiianPizzaBuilder);

        director.ConstructPizza();
        Pizza hawaiianPizza = hawaiianPizzaBuilder.GetPizza();

        Console.WriteLine("Hawaiian Pizza:");
        Console.WriteLine(hawaiianPizza);
    }
}
