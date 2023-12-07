namespace Demo.StoreExample.RulesPattern.Refactor;

public static class DateTimeExtensions
{
    public static DateTime ToValueOrDefault(this DateTime? dateTime, DateTime? defaultValue = null)
    {
        return dateTime ?? defaultValue ?? DateTime.Now;
    }
}