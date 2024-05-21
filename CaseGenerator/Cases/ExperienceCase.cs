namespace CaseGenerator.Cases
{
    public class ExperienceCase(double amount, double chance) : CaseBase(chance)
    {
        public override void Award()
        {
            Console.WriteLine($"Вы получили {amount} очков опыта!");
        }
    }
}
