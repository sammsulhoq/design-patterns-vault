namespace StrategyPattern.Shipping;

public class FedexShippingStrategy : IShippingStrategy
{
    public decimal CalculateShippingCost(decimal orderWeight, decimal orderTotal)
    {
        // FedEx rules: Base cost + weight penalty, free if total > $150
        if (orderTotal > 150) return 0;
        return 5.50m + (orderWeight * 0.75m);
    }
}