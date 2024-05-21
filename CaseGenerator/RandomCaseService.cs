using CaseGenerator.Cases;

namespace CaseGenerator
{
    public class RandomCaseService
    {
        private readonly List<CaseBase> _cases;
        private readonly Random _random;
        private readonly double _totalChance;

        public RandomCaseService()
        {
            _cases = InitializeCases();
            _random = new Random();
            _totalChance = _cases.Sum(c => c.Chance);
        }

        public CaseBase GetRandomCase()
        {
            var randomNumber = _random.NextDouble() * _totalChance;
            var cumulativeChance = 0.0;

            foreach (var lootCase in _cases)
            {
                cumulativeChance += lootCase.Chance;
                if (randomNumber <= cumulativeChance)
                {
                    return lootCase;
                }
            }

            //В случае если кейс не выбран, вернуть первый элемент (не должно произойти при правильном распредилении вероятностей)
            return _cases[0];
        }

        private static List<CaseBase> InitializeCases()
        {
            return
            [
                new MoneyCase(10000, 15.0),
                new MoneyCase(50000, 10.0),
                new DonateCurrencyCase(1000, 15.0),
                new DonateCurrencyCase(5000, 10.0),
                new ExperienceCase(5000, 25.0),
                new ExperienceCase(25000, 10.0),
                new VehicleCase("Adder", 5.0),
                new VehicleCase("Primo", 10.0)
            ];
        }
    }
}
