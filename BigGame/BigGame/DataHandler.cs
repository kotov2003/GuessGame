namespace NumberGame
{
    public static class DataHandler
    {
        public static bool EvaluateInputData(string userNumber, string compNumber, Herd herd)
        {
            var actual = userNumber.ToArray();
            var expected = compNumber.ToArray();

            for (var i = 0; i < userNumber.Length; i++)
            {
                var char1 = userNumber[i];
                var index = Array.IndexOf(expected, char1);
                if (index != -1)
                {
                    if (i == index)
                        herd.Bulls += 1;
                    else
                        herd.Cows += 1;
                }
            }
            UserInteraction.ShowWarningMessage($"Bulls: {herd.Bulls}\nCows: {herd.Cows}");

            return herd.Bulls == 4;
        }
    }
}
