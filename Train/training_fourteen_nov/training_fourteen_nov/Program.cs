using System;

class program
{

    struct employee
    {
        public int id;
        public string FirstName;
        public string LastName;
        public int age;
        public string city;
        public decimal salary;

        public employee() //parameterless 
        {
            id = 101;
            FirstName = "Yeshan";
            LastName = "Sahody";
            age = 24;
            city = "London";
            salary = 55000.89m;
        }

        public employee(int id,string FirstName,string LastName,int age,string city, int salary)
        {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.age = age;
            this.city = city;
            this.salary = salary;
        }

        public string GetDetails()
        {
            return $"{id} - {FirstName} {LastName}, is age - {age} years old, comes from {city}. {FirstName} {LastName} 'salary is {salary} per month";

        }

    }
    static void Main()
    {
        /*int[] array = { 100,89,89,41,96,78,2,95,1005,201 };

        if (array.Length < 3)
        {
            Console.WriteLine("The array should have at least three elements.");
            return;
        }

        var SortedArray = array.Distinct().OrderByDescending(x => x).ToArray();

        if (SortedArray.Length < 3)
        {
            Console.WriteLine("There are less than three distinct elements in the array.");
            return;
        }

        Console.WriteLine("The largest three distinct elements are:");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(SortedArray[i]);
        }*/

        employee one  = new employee();
        employee two = new employee();
        employee three = new employee(54, "John", "Law", 56, "Poland", 58000);

        one.id = 1;
        one.FirstName = "Yeshan";
        one.LastName = "Sahody";
        one.age = 23;
        one.city = "Belgium";
        one.salary = 30000.50m;

        Console.WriteLine(one.GetDetails());
        Console.WriteLine(two.GetDetails());
        Console.WriteLine(three.GetDetails());
    }
}

