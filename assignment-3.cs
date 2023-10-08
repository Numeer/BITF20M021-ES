using System;

class Program{
    static void Main(){

        Console.WriteLine("****************** TASK 1 A ******************");
        Greet();
        Greet(name:"Hi");
        Greet("Numeer","Hi");

        Console.WriteLine("****************** TASK 1 B ******************");
        calculateArea();
        calculateArea(2.0,3.0);

        Console.WriteLine("****************** TASK 1 C ******************");
        Console.WriteLine($"Sum is : {addNumber(2,3)}");
        Console.WriteLine($"Sum is : {addNumber(2,3,4)}");
        Console.WriteLine($"Sum is : {addNumber()}");

        Console.WriteLine("****************** TASK 1 D ******************");
        Book b1 = new Book("C#");
        Console.WriteLine($"Book 1: {b1.title} by {b1.author}");
        Book b2 = new Book("C++","Numeer");
        Console.WriteLine($"Book 2: {b2.title} by {b2.author}");


        Console.WriteLine("****************** TASK 2 A ******************");
        // Integers
        MyList<int> intList = new MyList<int>();
        intList.AddElement(10);
        intList.AddElement(20);
        intList.AddElement(30);
        intList.DisplayList();

        // // Remove an element from the integer list
        intList.RemoveElement(20);
        intList.DisplayList();

        // // Strings
        MyList<string> stringList = new MyList<string>();
        stringList.AddElement("Apple");
        stringList.AddElement("Banana");
        stringList.AddElement("Orange");
        stringList.DisplayList();

        // // Remove an element from the string list
        stringList.RemoveElement("Banana");
        stringList.DisplayList();

        Console.WriteLine("****************** TASK 2 B ******************");
        // Swap two integers
        int a = 10, b = 20;
        Console.WriteLine($"Before swap: a = {a}, b = {b}");
        Swap<int>(ref a, ref b);
        Console.WriteLine($"After swap: a = {a}, b = {b}");

        // Swap two strings
        string x = "Hello", y = "World";
        Console.WriteLine($"Before swap: x = {x}, y = {y}");
        Swap<string>(ref x, ref y);
        Console.WriteLine($"After swap: x = {x}, y = {y}");

        Console.WriteLine("****************** TASK 2 C ******************");
        int[] intArray = { 1, 2, 3, 4, 5 };
        double[] doubleArray = { 1.5, 2.5, 3.5, 4.5, 5.5 };

        int sumInt = SumArray(intArray);
        double sumDouble = SumArray(doubleArray);

        Console.WriteLine($"Sum of intArray: {sumInt}");
        Console.WriteLine($"Sum of doubleArray: {sumDouble}");
        
        Console.WriteLine("****************** TASK 2 D ******************");
        StudentDatabase database = new StudentDatabase();

        // Add student records to the database
        database.AddStudent(101, "Alice");
        database.AddStudent(102, "Bob");
        database.AddStudent(103, "Charlie");
        database.AddStudent(104, "David");

        
        int choice;
        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. View the student database");
            Console.WriteLine("2. Search for a student by ID");
            Console.WriteLine("3. Update a student's name");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice (1-4): ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        database.DisplayDatabase();
                        Console.WriteLine("\n");
                        break;
                    case 2:
                        Console.Write("\nEnter student ID to search: ");
                        if (int.TryParse(Console.ReadLine(), out int searchId))
                        {
                            string result = database.GetStudentName(searchId);
                            Console.WriteLine(result);
                            Console.WriteLine("\n");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!! Please enter a valid integer:) \n");
                        }
                        break;
                    case 3:
                        Console.Write("\nEnter student ID to update name: ");
                        if (int.TryParse(Console.ReadLine(), out int updateId))
                        {
                            Console.Write("Enter new name: ");
                            string newName = Console.ReadLine() ?? "";
                            database.UpdateStudentName(updateId, newName);

                        }
                        else
                        {
                            Console.WriteLine("\nInvalid input!! Please enter a valid integer:) \n");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nExiting the program.");
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice!! Please enter a number between 1 and 4:) \n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (choice != 4);
    }
    static void Greet(string greeting="Hello", string name="World"){
        Console.WriteLine($"{greeting}, {name}!");
    }
    static void calculateArea(double length=1.0, double width=1.0){
        Console.WriteLine($"Area of rectangle is {length*width}");
    }
    static int addNumber(int a, int b){
        return a+b;
    }
    static int addNumber(int a=0, int b=0, int c=0){
        return a+b+c;
    }
    class Book{
        public string title {get;set;}
        public string author {get;set;}

        public Book(string title, string author="Unknown"){
            this.title = title;
            this.author = author;
        }
        
    }
    class MyList<T>{
        private List<T> elements = new List<T>();
        public void AddElement(T element)
        {
            elements.Add(element);
        }

        public bool RemoveElement(T element)
        {
            return elements.Remove(element);
        }

        public void DisplayList()
        {
            Console.WriteLine("List Elements:");
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }
    }
    static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }
     static T SumArray<T>(T[] array) where T : struct, IConvertible
    {
        if (!typeof(T).IsPrimitive || typeof(T) == typeof(char) || typeof(T) == typeof(bool))
        {
            throw new ArgumentException("Unsupported type. Only numeric types are allowed.");
        }

        dynamic sum = 0;

        foreach (T element in array)
        {
            sum += element;
        }

        return sum;
    }
    class StudentDatabase
    {
        private Dictionary<int, string> studentDict = new Dictionary<int, string>();

        public void AddStudent(int studentId, string name)
        {
            studentDict[studentId] = name;
        }

        public string GetStudentName(int studentId)
        {
            if (studentDict.ContainsKey(studentId))
            {
                return studentDict[studentId];
            }
            else
            {
                return "Student not found :( ";
            }
        }

        public void DisplayDatabase()
        {
            Console.WriteLine("\nStudent Database:");
            foreach (var entry in studentDict)
            {
                Console.WriteLine($"Student ID: {entry.Key}, Name: {entry.Value}");
            }
        }

        public void UpdateStudentName(int studentId, string newName)
        {
            if (studentDict.ContainsKey(studentId))
            {
                studentDict[studentId] = newName;
                Console.WriteLine("Student name updated successfully \n");
            }
            else
            {
                Console.WriteLine("Student not found!! Name not updated :( \n");
            }
        }
    }
}