using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator(5,6);
            Console.WriteLine("{0}", c.answer);
            
        }
    }

    public class Calculator
    {
        // let's make a Class Variable
        // stuff the answer into that class variable
        // and access that variable up in our Program class

        public double answer;
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
        public void Add(float a, float b)
        {
            answer = a + b;
            Console.WriteLine("*** debug msg: Add method output is {0}", answer);
            
        }


    }
}
