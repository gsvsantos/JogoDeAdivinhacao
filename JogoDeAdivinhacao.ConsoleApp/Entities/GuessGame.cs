using JogoDeAdivinhacao.ConsoleApp.Entities.Utils;

namespace JogoDeAdivinhacao.ConsoleApp.Entities
{
    class GuessGame
    {
        public static Random Random = new Random();
        public static int RandomNumber;
        public static int NewMaxRandomNumber = 0;
        public static int ActualAttempt = 1;
        public static int MaxAttempts = 5;
        public static bool IsPersonalized = false;

        public static void MainMenu()
        {
            bool mainMenu = true;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Menu Principal");
                Console.WriteLine("----------------------------------\n");
                Console.WriteLine("Digite 1 Para Iniciar Partida");
                Console.WriteLine("Digite 2 Para Acessar as Dificuldades");
                Console.WriteLine("Digite S Para Voltar à Tela Inicial");

                string option = Auxiliary.OptionVerify("\nOpção: ", ["1", "2", "S"]);

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        GameStart();
                        break;
                    case "2":
                        Console.Clear();
                        GameModes();
                        break;
                    case "S":
                        Console.Clear();
                        mainMenu = false;
                        break;
                }
            } while (mainMenu);
        }
        public static void GameStart()
        {
            bool gotMaxAttemps, userGuessed;

            GenerateRandomNumber();
            do
            {
                int userGuess = GetUserGuess();
                gotMaxAttemps = CheckAttemps();
                if (gotMaxAttemps == true)
                    break;
                userGuessed = CheckGuessTry(userGuess);
            } while (userGuessed == false);

            Console.Write("\nPressione [Enter] para voltar ao menu.");
            Console.ReadKey();
            ActualAttempt = 1;
            return;
        }
        public static bool CheckGuessTry(int userGuess)
        {
            if (userGuess == RandomNumber)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Você acertou o número sorteado!!");
                Console.WriteLine("----------------------------------------------");
                return true;
            }
            else if (userGuess > RandomNumber)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("O seu número é maior que o número sorteado!!");
            }
            else if (userGuess < RandomNumber)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("O seu número é menor que o número sorteado!!");
            }
            ActualAttempt++;
            return false;
        }

        public static int GetUserGuess()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Tentativa {ActualAttempt} de {MaxAttempts}");
            Console.WriteLine("----------------------------------------------");
            int choosenNumber = Auxiliary.IntVerify("\nDigite um número: ", "\nPrecisa ser um número inteiro válido...");
            return choosenNumber;
        }
        public static bool CheckAttemps()
        {
            if (ActualAttempt == MaxAttempts)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Que pena! Você estorou suas tentativas!");
                Console.WriteLine($"O número secreto era > {RandomNumber} <");
                Console.WriteLine("----------------------------------------------");
                return true;
            }
            return false;
        }
        public static void GenerateRandomNumber()
        {
            if (IsPersonalized == true)
            {
                RandomNumber = Random.Next(1, NewMaxRandomNumber);
            }
            else
            {
                RandomNumber = Random.Next(1, 21);
            }
        }
        public static void GameModes()
        {
            bool onMenu = true;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Dificuldades");
                Console.WriteLine("----------------------------------\n");
                Console.WriteLine("Digite 1 Para Jogar no Fácil");
                Console.WriteLine("Digite 2 Para Jogar no Médio");
                Console.WriteLine("Digite 3 Para Jogar no Difícil");
                Console.WriteLine("Digite 4 Para Jogar um modo Personalizado");
                Console.WriteLine("Digite S Para Voltar ao Menu Principal");
                Console.Write("\nEscolha o modo que queira jogar: ");

                string option = Auxiliary.OptionVerify("\nOpção: ", ["1", "2", "3", "4", "S"]);
                if (option == "1")
                {
                    IsPersonalized = false;
                    MaxAttempts = 10;
                    Console.WriteLine("\nDificuldade Fácil escolhida!\nVocê terá 10 tentativas, easy peasy!");
                }
                if (option == "2")
                {
                    IsPersonalized = false;
                    MaxAttempts = 5;
                    Console.WriteLine("\nDificuldade Médio escolhido!\nVocê terá 5 tentativas, boa sorte!");
                }
                if (option == "3")
                {
                    IsPersonalized = false;
                    MaxAttempts = 3;
                    Console.WriteLine("\nDificuldade Difícil escolhido!\nVocê terá 3 tentativas, força, guerreiro(a)!!");
                }
                if (option == "4")
                {
                    MaxAttempts = Auxiliary.IntVerify("\nQuantas tentativas você terá? ", "\nPrecisa ser um número inteiro válido...");

                    NewMaxRandomNumber = Auxiliary.IntVerify("\nQual o novo limite (Padrão 20)? ", "\nPrecisa ser um número inteiro válido...");
                    if (MaxAttempts > 10)
                    {
                        Console.Clear();
                        Console.WriteLine($"\nEntão você decidiu jogar no modo mais fácil que o fácil?");
                    }
                    else if (MaxAttempts < 3)
                    {
                        Console.Clear();
                        Console.WriteLine($"\nMais difícil que no difícil, boa sorte! Vai precisar...");
                    }
                    if (MaxAttempts == 1)
                    {
                        Console.WriteLine($"Será gerado um número de 1 até {NewMaxRandomNumber}, e você terá {MaxAttempts} tentativa!");
                    }
                    else
                        Console.WriteLine($"Será gerado um número de 1 até {NewMaxRandomNumber}, e você terá {MaxAttempts} tentativas!");
                    RandomNumber = Random.Next(1, ++NewMaxRandomNumber);
                    IsPersonalized = true;
                }
                if (option == "S")
                {
                    break;
                }
                Console.Write("\nPressione [Enter] para continuar!");
                Console.ReadKey();
            } while (onMenu);
        }
    }

}
