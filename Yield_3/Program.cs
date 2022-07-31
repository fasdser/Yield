using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

         foreach (var arg in UserCollection.Power())
                Console.WriteLine(arg);

            Console.WriteLine(new string('-',15));

            IEnumerable enumerable = UserCollection.Power();
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                String element = enumerator.Current as String;
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
