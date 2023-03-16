namespace NumberGame
{
    internal class FourDigitValidator : IValidator
    {
        public bool ValidateUserNumber(string userNumber)
        {
            return !string.IsNullOrEmpty(userNumber) && userNumber.Length == 4 && userNumber.All(char.IsDigit);
        }
    }
}
