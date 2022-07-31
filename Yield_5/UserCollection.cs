using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield_5
{
    class UserCollection
    {

        public static IEnumerable Power()
        {
            while (true)
                yield return "Hello world!";
        }
    }
}
