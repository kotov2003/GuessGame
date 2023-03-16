namespace NumberGame
{
    internal static class GenerateNumberService
    {
        public static string GenerateNumber()
        {
            List<string> numbers = new List<string>();
            string number = default;

            for (int i = 0; i < 4; i++)
            {
                do
                {
                    number = new Random().Next(0, 9).ToString();

                } while (numbers.Contains(number));

                numbers.Add(number);
            }

            return string.Concat(numbers);
        }
    }
}
