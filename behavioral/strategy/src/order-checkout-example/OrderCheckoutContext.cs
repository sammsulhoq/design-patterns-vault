namespace StrategyPattern.Shipping;

public class OrderCheckoutContext
{
    private IShippingStrategy _shippingStrategy;

    // Strategy is injected via constructor (or changed at runtime via property)
    public OrderCheckoutContext(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public void SetShippingStrategy(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public decimal ExecuteCheckout(decimal weight, decimal total)
    {
        return _shippingStrategy.CalculateShippingCost(weight, total);
    }
}