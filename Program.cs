using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number which I will do some Math operations on.");
            string line = Console.ReadLine();
            
            Data = Int32.Parse(line);
            
            var operatorObject = new Operator();
            var result = operatorObject.GetAdd(Data);
            
            Console.WriteLine("Your answer is " + result);
            Console.ReadLine();
        }
    }
}