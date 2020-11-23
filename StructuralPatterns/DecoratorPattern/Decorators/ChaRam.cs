using DecoratorPattern.Base;

namespace DecoratorPattern.Decorators
{
    public class ChaRam : BunDauDecorator
    {
        public ChaRam(IBunDau inner) : base(inner)
        {
        }

        public override double Cost()
        {
            return 5 + base.Cost();
        }
    }
}
