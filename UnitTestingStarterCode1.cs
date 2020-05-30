using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            Console.WriteLine("{0}", c.Add(6, 7));
            Console.WriteLine("{0}", c.Substract(6, 7));
            Console.WriteLine("{0}", c.Multiply(6, 7));
            Console.WriteLine("{0}", c.Devide(6, 7));
            Console.WriteLine("{0}", c.Exponentiate(6, 7));
        }
    }

    public class Calculator
    {
        // let's make a Class Variable
        // stuff the answer into that class variable
        // and access that variable up in our Program class

        // lets make a zero argument constructor!
        public Calculator() { }
        public Calculator(int input1, int input2)
        {
            Console.Write("I am in he Constructor!");
            this.Add(input1, input2);
        }

        // pay attention to the METHOD SIGNATURE:
        // visibility: public, private, protected, default
        // return type: double
        // name: Add
        // method parameters
        public float Add(float a, float b)
        {
            return (a + b);
        }
        public float Substract(float a, float b)
        {
            return (a - b);
        }


    }
}
