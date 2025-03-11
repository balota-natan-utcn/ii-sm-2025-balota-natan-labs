using System;
using System.Collections.Generic;
using Lab1;

class Fibonacci
{
    static List<int> GetFibonacci(int n)
    {
        List<int> fibSequence = new List<int> { 0, 1 }; //incepe cu primii doi termeni

        //calculeaza urmatorii termeni din secventa
        for (int i = 2; i < n; i++)
        {
            int nextTerm = fibSequence[i - 1] + fibSequence[i - 2];
            fibSequence.Add(nextTerm);
        }

        return fibSequence.GetRange(0, n); //returneaza doar primii n termeni
    }

    static void executeFibo()
    {
        Console.WriteLine("Introdu numarul de termeni cautat: ");
        int n = int.Parse(Console.ReadLine());

        List<int> fibonacciSequence = GetFibonacci(n);

        Console.WriteLine("Primii " + n + " termeni ai secventei Fibonacci sunt: ");
        foreach (int term in fibonacciSequence)
        {
            Console.WriteLine(term + " ");
        }
    }

    static int idealWeight(int height, int age, string sex)
    {
        int idWeight;

        if (sex == "M")
        {
            idWeight = (height - 100 - (-150 / 4) + ((age - 20) / 4));
        }
        else if (sex == "F")
        {
            idWeight = ((height - 100) - ((height - 150) / 4) + ((age - 20) / 6));
        }
        else
        {
            return 1;
        }

        return idWeight;
    }

    static void executeIdealWt()
    {
        Console.WriteLine("Introdu sex(M - F): ");
        string sex = Console.ReadLine();
        Console.WriteLine("Introdu inaltime: ");
        string inpt = Console.ReadLine();
        int height = int.Parse(inpt);
        Console.WriteLine("Introdu varsta: ");
        inpt = Console.ReadLine();
        int age = int.Parse(inpt);

        Console.WriteLine("sex: " + sex + " inaltime: " + height + " varsta: " + age);

        int GreutateaIdeala = idealWeight(height, age, sex);

        Console.WriteLine("Greutatea ideala= " + GreutateaIdeala);
    }

    static void testStack()
    {
        Stack stack = new Stack();

        stack.Push(5);
        stack.Push(15);
        stack.Push(8);

        stack.PrintStack();
        Console.WriteLine("Number of elements in stack: " + stack.elementsNr());

        stack.Pop();
        Console.WriteLine("Number of elements after popping: " + stack.elementsNr());

        stack.PrintStack();
    }

    static void testCar()
    {
        Console.Write("Enter the number of cars: ");
        int n = int.Parse(Console.ReadLine());

        List<Car> cars = new List<Car>();

        // Reading n cars from the user
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter details for car {i + 1}:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Engine Power (HP): ");
            int power = int.Parse(Console.ReadLine());

            Console.Write("Price ($): ");
            decimal price = decimal.Parse(Console.ReadLine());

            cars.Add(new Car(name, power, price));
        }

        // Sorting the list using our custom comparison
        cars.Sort(Car.compareCars);

        // Display sorted cars
        Console.WriteLine("\nCars sorted by power (desc) and price (asc):");
        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }

    static void Main()
    {
        //executeFibo();
        //executeIdealWt();
        //testStack();
        //testCar();
    }
}