namespace CaseGenerator.Cases
{
    public class DonateCurrencyCase(decimal amount, double chance) : CaseBase(chance)
    {
        public override void Award()
        {
            Console.WriteLine($"Вы получили {amount} донат валюты!");
        }
    }
}
