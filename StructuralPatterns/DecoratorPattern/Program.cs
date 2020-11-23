using System;
using DecoratorPattern.Base;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Combo 1
            var comBo1 = new ChaRam(
                            new ChaCom(
                                new LongRan(
                                    new NemRan(
                                        new ThitLuoc(
                                            new BunDau())))));
            Console.WriteLine("Bun Dau Day Du :\t" + comBo1.Cost() + " nghìn VND");

           
            //Combo 2
            var comBo2 = new ChaCom(
                            new ChaRam(
                                new BunDau()));
            Console.WriteLine("Bun Dau Them ChaCom + NemRan:\t" + comBo2.Cost() + " nghìn VND");
            
            //Combo3
            var comBo3 = new ChaCom(
                            new ChaRam(
                                new LongRan(
                                    new BunDau())));
            Console.WriteLine("Bun Dau Them ChaCom + ChaRom + LongRan:\t" + comBo3.Cost() + " nghìn VND");
            
            //combo4
            var comBo4 = new ThitLuoc(
                             new LongRan(
                                 new ChaCom(
                                    new BunDau())));
            Console.WriteLine("Bun Dau Them ThitLuoc + LongRan + ChaCom :\t" + comBo4.Cost() + " nghìn VND");

            //Combo 5
            var comBo5 = new ChaCom(
                                new BunDau());
            Console.WriteLine("Bun Dau Them ChaCom + NemRan:\t" + comBo5.Cost() + " nghìn VND");

        }
    }
}
