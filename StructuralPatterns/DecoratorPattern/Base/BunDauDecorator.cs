namespace DecoratorPattern.Base
{
    public abstract class BunDauDecorator : IBunDau
    {
        private IBunDau _bunDau;

        protected BunDauDecorator(IBunDau bunDau)
        {
            _bunDau = bunDau;
        }

        public virtual double Cost()
        {
            return _bunDau.Cost();
        }
    }
}
