namespace CaseGenerator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var randomCaseService = new RandomCaseService();

            for (var i = 0; i < 10; i++)
            {
                var randomCase = randomCaseService.GetRandomCase();

                randomCase.Award();
            }
        }
    }
}
