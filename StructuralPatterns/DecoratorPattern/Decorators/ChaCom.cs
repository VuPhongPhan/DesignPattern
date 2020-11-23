using DecoratorPattern.Base;

namespace DecoratorPattern.Decorators
{
    public class ChaCom : BunDauDecorator
    {
        public ChaCom(IBunDau inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 5 + base.Cost();
        }
    }
}
