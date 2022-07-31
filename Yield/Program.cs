using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield
{
    internal class Program
    {
        static void Main(string[] args)
        {

            foreach (var element in UserCollection.Power())
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(new string('-', 12));


            IEnumerable enumerable = UserCollection.Power();

            IEnumerator enumerator = enumerable.GetEnumerator();

            while (enumerator.MoveNext())
            {
                String element = (String)enumerator.Current;
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
