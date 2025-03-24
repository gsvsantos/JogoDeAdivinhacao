using JogoDeAdivinhacao.ConsoleApp.Entities;
using JogoDeAdivinhacao.ConsoleApp.Entities.Utils;

namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool homeScreen = true;
            do
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Boas vindas ao Jogo de Adivinhação :O");
                Console.WriteLine("------------------------------------------\n");
                Console.WriteLine("Digite 1 Para Iniciar o Jogo");
                Console.WriteLine("Digite S Para Fechar o Jogo");
                string option = Auxiliary.OptionVerify("\nOpção: ", ["1", "S"]);

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        GuessGame.MainMenu();
                        break;
                    case "S":
                        homeScreen = false;
                        Console.Clear();
                        Console.WriteLine("Adeus T_T");
                        break;
                }
            } while (homeScreen);
        }
    }
}
