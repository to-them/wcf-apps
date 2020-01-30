using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceClientConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n  Test WCF Service");
            DoCalculation();
            Console.Write("\n Press any key to exit:");
            Console.ReadKey();
        }

        static void DoCalculation()
        {
            WcfCalculatorServiceReference.CalculatorServiceClient cal = new WcfCalculatorServiceReference.CalculatorServiceClient();
            double add = cal.Add(2, 2);
            Console.WriteLine(" Add: {0}", add);

            double subtract = cal.Subtract(4, 3);
            Console.WriteLine(" Subtract: {0}", subtract);

        }
    }
}
