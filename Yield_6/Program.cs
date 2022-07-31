using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in UserCollection.Power())
                Console.WriteLine(arg);
            Console.ReadLine();
        }
    }
}
