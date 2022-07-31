using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yield
{
    class UserCollection
    {

        public static IEnumerable Power()
        {
            yield return "Hello world";
        }
    }
}
