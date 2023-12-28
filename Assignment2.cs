using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("**************** Task 1 ****************");
        StringConcatenation();
        Console.WriteLine("\n************** Task 2 ****************");
        SubstringFetching();
        Console.WriteLine("\n************** Task 3 ****************");
        StringInterpolation();
        Console.WriteLine("\n************** Task 4 ****************");
        ArrayDeclaration();
        Console.WriteLine("\n************** Task 5 A ****************");
        string[] fruits = { "Apple", "Banana", "Orange", "Grapes", "Mango", "Pineapple", "Watermelon" };
        ArrayIterationUsingFor(fruits);
        Console.WriteLine("\n************** Task 5 B ****************");
        string[] colors = { "Red", "Blue", "Green", "Yellow", "Orange", "Purple", "Pink", "Black" };
        ArrayIterationUsingForEach(colors);
        Console.WriteLine("\n************** Task 6 ****************");
        SumOfArrayElements();
        Console.WriteLine("\n************** Task 7 ****************");
        int[] minimum =  { 11, 52, 33, 74, 85, 89, 99, 102, 103, 3};
        FindMinArray(minimum);
        Console.WriteLine("\n************** Task 8 ****************");
        int[] reverse = {11, 22, 33, 44, 55, 66, 77, 88 ,99};
        ReverseArray(reverse);
        Console.WriteLine("\n************** Task 9 A ****************");
        IntegerBoxing();
        Console.WriteLine("\n************** Task 9 B ****************");
        DoubleBoxing();
        Console.WriteLine("\n************** Task 10 A ****************");
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8};
        UnboxingA(numbers);
        Console.WriteLine("\n************** Task 10 B ****************");
        DisplayListElementsAndTypes();
        Console.WriteLine("\n************** Task 11 A ****************");
        DynamicVariable1();
        Console.WriteLine("\n************** Task 11 B ****************");
        DynamicVariable2();
    }
    static void StringConcatenation()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine() ?? "";

        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine() ?? "";

        string fullName = $"{firstName} {lastName}".Trim();

        Console.WriteLine("Your full name is: " + fullName);
    }
    static void SubstringFetching()
    {
        Console.Write("Enter a sentence: ");
        string inputSentence = Console.ReadLine() ?? "";
        if (inputSentence.Length >= 5)
        {
            string lastFiveCharacters = inputSentence.Substring(inputSentence.Length - 5);
            Console.WriteLine("Last 5 characters: " + lastFiveCharacters);
        }
        else
        {
            Console.WriteLine("The sentence is too short to extract the last 5 characters.");
        }
    }
    static void StringInterpolation()
    {
        double temperature;
        string city;

        Console.Write("Enter the current temparature ");
        while (!double.TryParse(Console.ReadLine(), out temperature))
        {
            Console.WriteLine("Invalid input!! Please enter a valid temperature :)");
            Console.Write("Enter the current temperature: ");
        }
        Console.Write("Enter the city name ");
        city = Console.ReadLine() ?? "";
        Console.WriteLine($"The temperature in {city} is {temperature} degrees Celsius.");
    }
    static void ArrayDeclaration()
    {
        int [] numbers = {1,2,3,4,5};

        Console.Write("Array elements are : ");
        foreach (int item in numbers)
        {
            Console.Write(item + " ");
        }
    }
    static void ArrayIterationUsingFor(string[] fruits)
    {
        Console.WriteLine("Fruits are : ");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine(fruits[i] + " ");
        }
        Console.Write("\n");
    }
    static void ArrayIterationUsingForEach(string[] colors)
    {
        Console.WriteLine("Colors are : ");
        foreach (string color in colors)
        {
            Console.WriteLine(color + " ");
        }
        Console.Write("\n");
    }
    static void SumOfArrayElements()
    {
        int[] scores = { 11, 52, 33, 74, 85, 89, 99, 102, 103, 104};
        int sum = 0, index=0;
        do
        {
            sum += scores[index];
            index++;
        }while( index < scores.Length);
        Console.WriteLine("Sum of array elements is: " + sum);
    }
    static void FindMinArray(int[] minimum)
    {
        int min = minimum[0];
        int i = 1;
        while(i < minimum.Length)
        {
            if (minimum[i] < min)
            {
                min = minimum[i];
            }
            i++;
        }
        Console.WriteLine("Minimum value in the array is: " + min);
    }
    static void ReverseArray(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;
            left++;
            right--;
        }
        Console.WriteLine("Reversed array is: ");
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
    }
    static void IntegerBoxing()
    {
        int x = 42;
        object obj = x;
        int y = (int) obj;
        Console.WriteLine("Value of y is: " + y);
    }
    static void DoubleBoxing()
    {
        double doubleValue = 3.14159;
        object obj = doubleValue;
        double unboxedValue = (double) obj;
        Console.WriteLine("Value of unboxed variable is: " + unboxedValue);
    }
    static void UnboxingA(int[] values)
    {
        int square;
        foreach(int value in values)
        {
            object obj = value;
            int unboxedValue = (int) obj;
            square = unboxedValue * unboxedValue;
            Console.WriteLine("Original value is " + value + " and Squared value is " + square);
        }
    }
    static void DisplayListElementsAndTypes()
    {
        List<object> mixedList = new List<object>();
        
        mixedList.Add(42);
        mixedList.Add(3.14);
        mixedList.Add('A');
        mixedList.Add("Hello");
        mixedList.Add(true);

        Console.WriteLine("List elements and their types:");

        foreach (var item in mixedList)
        {
            Console.Write($"{item} - ");
            Console.WriteLine(item.GetType().Name);
        }
    }
    static void DynamicVariable1()
    {
        dynamic myVariable = 42;
        Console.WriteLine("Value of myVariable is " + myVariable);
        myVariable = "Hello, Dynamic";
        Console.WriteLine("Value of myVariable is " + myVariable);
    }
    static void DynamicVariable2()
    {
        dynamic myVariable2 = 42;
        Console.WriteLine($"Type of myVariable2 (integer): {myVariable2.GetType()}");
        myVariable2 = 3.14;
        Console.WriteLine($"Type of myVariable2 (double): {myVariable2.GetType()}");
        myVariable2 = DateTime.Now;
        Console.WriteLine($"Type of myVariable2 (DateTime): {myVariable2.GetType()}");
        myVariable2 = "Hello, Dynamic!";
        Console.WriteLine($"Type of myVariable2 (string): {myVariable2.GetType()}");
    }
}
