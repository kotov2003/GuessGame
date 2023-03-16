
namespace NumberGame
{
    internal class Game
    {
        private const string StopWord = "exit";
        private Herd herd = new Herd();
        private IValidator Validator = new FourDigitValidator();

        private string? UserNumber { get; set; }
        private string GeneratedNumber { get; set; }


        public Game(IValidator validator)
        {
            Validator = validator;
        }

        public Game()
        {
        }

        public void Start()
        {
            GeneratedNumber = GenerateNumberService.GenerateNumber();

            do

            {
                UserNumber = UserInteraction.GetInputData("\nEnter the four-digit number (type 'Exit' to quit):");

                if (UserNumber == StopWord)
                {
                    break;
                }

                if (!Validator.ValidateUserNumber(UserNumber))
                {
                    UserInteraction.ShowWarningMessage("Wrong input data format!");
                    continue;
                }

                if (DataHandler.EvaluateInputData(UserNumber, GeneratedNumber, herd))
                {
                    UserInteraction.ShowWarningMessage($"{new string('=', 55)}\nYou won!!! Congratulations!!!\nWe've generated a new one for you.Try to guess this one!\n{new string('=', 55)}");
                    GeneratedNumber = GenerateNumberService.GenerateNumber();
                }
                else
                {
                    UserInteraction.ShowWarningMessage($"{new string('-', 55)}\nTry it again... You can do better...\n{new string('-', 55)}");
                }

                CleanData();

            } while (UserNumber != StopWord);
        }

        private void CleanData()
        {
            herd.Bulls = 0; herd.Cows = 0;
        }
    }
}
