using JogoDeAdivinhacao.ConsoleApp.Entities.Utils;

namespace JogoDeAdivinhacao.ConsoleApp.Entities
{
    class DiceGame
    {
        public static Random Random = new Random();
        public static int RandomNumber;
        public static int NewMaxRandomNumber = 0;
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
            if (IsPersonalized == true)
            {
                RandomNumber = Random.Next(1, ++NewMaxRandomNumber);
            }
            else
            {
                RandomNumber = Random.Next(1, 21);
            }
            for (int i = 1; i <= MaxAttempts; i++)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine($"Tentativa {i} de {MaxAttempts}");
                Console.WriteLine("----------------------------------------------");
                int choosenNumber = Auxiliary.IntVerify("\nDigite um número: ", "\nPrecisa ser um número inteiro válido...");

                if (choosenNumber == RandomNumber)
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Você acertou o número sorteado!!");
                    Console.WriteLine("----------------------------------------------");
                    break;
                }
                else if (choosenNumber > RandomNumber)
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("O seu número é maior que o número sorteado!!");
                }
                else if (choosenNumber < RandomNumber)
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("O seu número é menor que o número sorteado!!");
                }
                if (i == MaxAttempts)
                {
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Que pena! Você estorou suas tentativas!");
                    Console.WriteLine($"O número secreto era > {RandomNumber} <");
                    Console.WriteLine("----------------------------------------------");
                    break;
                }
            }
            Console.Write("\nPressione [Enter] para voltar ao menu.");
            Console.ReadKey();
            return;
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
