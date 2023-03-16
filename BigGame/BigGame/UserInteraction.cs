namespace NumberGame
{
    internal static class UserInteraction
    {
        public static string GetInputData(string messageToShow)
        {
            Console.WriteLine(messageToShow);
            return Console.ReadLine().ToLower();
        }

        public static void ShowWarningMessage(string messageToShow)
        {
            Console.WriteLine($"\n{messageToShow}");
        }
    }
}
