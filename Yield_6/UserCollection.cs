using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Yield_6
{
    class UserCollection
    {

        public static IEnumerable Power()
        {
            return new ClassPower(-2);
        }

        private sealed class ClassPower:IEnumerable<object>, IEnumerator<object>, IEnumerator, IDisposable
        {
            private int state1;
            private object current2;
            private int initialThreadId_1;

            public ClassPower(int state)
            {
                this.state1 = state;
                this.initialThreadId_1 = Thread.CurrentThread.ManagedThreadId;
            }

            bool IEnumerator.MoveNext()
            {
                //switch (this.state1)
                //{
                //    case 0:
                //        this.state1 = -1;
                //        this.current2 = "Hello word!";
                //        this.state1 = 1;
                //        return true;
                //        case 1:
                //        this.state1 = -1;
                //        break;
                //}
                //return false;
                this.current2 = "Hello world!";
                this.state1 = 1;
                return true;
            }

            IEnumerator<object> IEnumerable<object>.GetEnumerator()
            {
                if ((Thread.CurrentThread.ManagedThreadId == this.initialThreadId_1) && (this.state1 == -2))
                {
                    this.state1 = 0;
                    return this;
                }
                return new UserCollection.ClassPower(0);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return (this as IEnumerable<object>).GetEnumerator();
            }

            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            void IDisposable.Dispose()
            {

            }

            object IEnumerator<object>.Current
            {
                get { return this.current2; }
            }

            object IEnumerator.Current
            {
                get { return this.current2; }
            }
        }
    }
}
