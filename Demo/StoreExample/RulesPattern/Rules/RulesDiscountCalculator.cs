namespace Demo.StoreExample.RulesPattern.Rules;

public class RulesDiscountCalculator : IDiscountCalculator
{
    private readonly List<IDiscountRule> _rules = [];

    public RulesDiscountCalculator()
    {
        _rules.Add(new BirthdayDiscountRule());
        _rules.Add(new SeniorDiscountRule());
        _rules.Add(new VeteranDiscountRule());
        _rules.Add(new LoyalCustomerRule(1, 0.10m));
        _rules.Add(new LoyalCustomerRule(5, 0.12m));
        _rules.Add(new LoyalCustomerRule(10, 0.20m));
        _rules.Add(new NewCustomerRule());
    }

    public decimal CalculateDiscountPercentage(Customer customer)
    {
        decimal discount = 0;

        foreach (var rule in _rules)
        {
            discount = Math.Max(rule.CalculateCustomerDiscount(customer), discount);
        }

        return discount;
    }
}