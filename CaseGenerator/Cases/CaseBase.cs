namespace CaseGenerator.Cases
{
    public abstract class CaseBase(double chance)
    {
        public double Chance { get; } = chance;

        public abstract void Award();
    }
}
