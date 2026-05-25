namespace StrategyPattern.Shipping;

public interface IShippingStrategy
{
    decimal CalculateShippingCost(decimal orderWeight, decimal orderTotal);
}