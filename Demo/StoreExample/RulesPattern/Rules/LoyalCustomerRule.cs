using Demo.StoreExample.RulesPattern.Refactor;

namespace Demo.StoreExample.RulesPattern.Rules;

public class LoyalCustomerRule(int yearsAsCustomer, decimal discount, DateTime? date = null)
    : IDiscountRule
{
    private readonly DateTime _date = date.ToValueOrDefault();

    public decimal CalculateCustomerDiscount(Customer customer)
    {
        if (customer.HasBeenLoyalForYears(yearsAsCustomer, _date))
        {
            var birthdayRule = new BirthdayDiscountRule();

            return discount + birthdayRule.CalculateCustomerDiscount(customer);
        }
        return 0;
    }
}