using NumberGame;

public class Program
{
    static void Main(string[] args)
    {
        var game = new Game(new SixDigitValidator());
        game.Start();
    }
}
