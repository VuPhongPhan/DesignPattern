using DecoratorPattern.Base;

namespace DecoratorPattern.Decorators
{
    public class LongRan : BunDauDecorator
    {
        public LongRan(IBunDau inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 5 + base.Cost();
        }
    }
}
