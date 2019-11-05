using System;

namespace BaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
    }

    public class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public Person(string f, string l)
        {
            Fname = f;
            Lname = l;
        }

        public Person(string f, string l, int a)
        {
            Fname = f;
            Lname = l;
            Age = a;
        }

        public string Greeting()
        {
            return $"Hello {Fname} {Lname}";
        }

        public int HasBirthday()
        {
            return Age + 1;
        }
        
    }
    public class SimpleCalculation
    {
        public int SumofTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public int ProductOfTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        public int SubstractOfTwoNumbers(int num1, int num2)
        {
            return num1 - num2;
        }

        public double DivisionOfTwoNumbers(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
