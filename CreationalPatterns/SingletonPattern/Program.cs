using System;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(() => Singleton.GetInstance().Helloworld());
            var thread2 = new Thread(() => Singleton.GetInstance().Helloworld());

            thread1.Start();
            thread2.Start();
        }
    }
}
