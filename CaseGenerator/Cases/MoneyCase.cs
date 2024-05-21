namespace CaseGenerator.Cases
{
    public class MoneyCase(decimal amount, double chance) : CaseBase(chance)
    {
        public override void Award()
        {
            Console.WriteLine($"Вы получили {amount}$!");
        }
    }
}
