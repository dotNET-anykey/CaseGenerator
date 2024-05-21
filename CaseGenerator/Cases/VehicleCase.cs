namespace CaseGenerator.Cases
{
    public class VehicleCase(string vehicleName, double chance) : CaseBase(chance)
    {
        public override void Award()
        {
            Console.WriteLine($"Вы получили '{vehicleName}'!");
        }
    }
}
