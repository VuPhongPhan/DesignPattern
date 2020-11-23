using DecoratorPattern.Base;

namespace DecoratorPattern.Decorators
{
    public class NemRan : BunDauDecorator
    {
        public NemRan(IBunDau inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 5 + base.Cost();
        }
    }
}
