namespace Demo.StoreExample.RulesPattern.Rules;

public interface IDiscountRule
{
    decimal CalculateCustomerDiscount(Customer customer);
}