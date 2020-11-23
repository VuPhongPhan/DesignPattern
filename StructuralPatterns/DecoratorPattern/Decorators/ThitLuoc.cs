using DecoratorPattern.Base;

namespace DecoratorPattern.Decorators
{
    public class ThitLuoc : BunDauDecorator
    {
        public ThitLuoc(IBunDau inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 5 + base.Cost();
        }
    }
}
