using System;
namespace SingletonPattern
{
    public class Singleton
    {
        private int index;
        private static readonly object lockObject = new object();
        private static volatile Singleton uniqueInstance;
        /// <summary>
        /// 1. volatile để sử dụng phiên bản update mới nhất của object (uniqueInstance)
        /// 2. biến lockObject để xét điều kiện không cho sinh ra uniqueInstance thứ 2 khi có nhiều thread 
        /// </summary>
        /// <param name="index"></param>

        private Singleton(int index)
        {
            this.index = index;
        }

        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (lockObject)
                {
                    if (uniqueInstance == null)
                    {
                        var random = new Random();

                        uniqueInstance = new Singleton(random.Next(1, 4));
                    }
                }
            }
            return uniqueInstance;
        }

        public void Helloworld()
        {
            Console.WriteLine("Chao ban!, Ban vua tao 1 Instance thu " + index);
        }
    }
}
