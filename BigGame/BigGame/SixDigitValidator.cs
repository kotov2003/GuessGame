namespace NumberGame
{
    internal class SixDigitValidator : IValidator
    {
        public bool ValidateUserNumber(string userNumber)
        {
            return !string.IsNullOrEmpty(userNumber) && userNumber.Length == 6 && userNumber.All(char.IsDigit);
        }
    }
}
