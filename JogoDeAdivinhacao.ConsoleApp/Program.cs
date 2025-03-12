namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 21);
                int maxAttempts = 0;

                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Jogo de Adivinhação");
                Console.WriteLine("----------------------------------");

                Console.WriteLine("Dificuldades:");
                Console.WriteLine("[1] Fácil (10 tentativas)");
                Console.WriteLine("[2] Médio (5 tentativas)");
                Console.WriteLine("[3] Difícil (3 tentativas)");
                Console.WriteLine("[4] Personalizado");
                Console.WriteLine("[S] Sair");

                Console.Write("\nEscolha o modo que queira jogar:");
                string option = Console.ReadLine().ToUpper();

                if (option == "1")
                {
                    maxAttempts = 10;
                }
                else if (option == "2")
                {
                    maxAttempts = 5;
                }
                else if (option == "3")
                {
                    maxAttempts = 3;
                }
                else if (option == "4")
                {
                    Console.Write("\nQuantas tentativas você terá? ");
                    maxAttempts = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nQual o novo limite? (Padrão 20)");
                    int newMaxRandomNumber = Convert.ToInt32(Console.ReadLine());
                    randomNumber = random.Next(1, ++newMaxRandomNumber);
                }
                else if (option == "S")
                {
                    Console.WriteLine("Adiós! T_T");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("\nOpção inválida!\nPressione [Enter] e escolha novamente!");
                    Console.ReadKey();
                    continue;
                }

                for (int i = 1; i <= maxAttempts; i++)
                {
                    Console.WriteLine("-------------------------");
                    Console.WriteLine($"Tentativa {i} de {maxAttempts}");
                    Console.WriteLine("-------------------------");

                    Console.Write("Digite um número: ");
                    int choosenNumber = Convert.ToInt32(Console.ReadLine());

                    if (choosenNumber == randomNumber)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Você acertou o número sorteado!!");
                        Console.WriteLine("----------------------------------");
                        break;
                    }
                    else if (choosenNumber > randomNumber)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("O seu número é maior que o número sorteado!!");
                        Console.WriteLine("----------------------------------------------");
                    }
                    else if (choosenNumber < randomNumber)
                    {
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine("O seu número é menor que o número sorteado!!");
                        Console.WriteLine("----------------------------------------------");
                    }

                    if (i == maxAttempts)
                    {
                        Console.WriteLine("----------------------------------");
                        Console.WriteLine("Que pena! Você estorou suas tentativas!");
                        Console.WriteLine($"O número secreto era {randomNumber}");
                        Console.WriteLine("----------------------------------");
                        break;
                    }
                }

                Console.Write("Deseja jogar novamente? (S/N): ");
                string optionContinue = Console.ReadLine().ToUpper();

                while (optionContinue != "S" && optionContinue != "N")
                {
                    Console.Write("\nOpção inválida!\n\nPressione <Enter> e selecione novamente.");
                    Console.Write("\nDeseja continuar? (S/N): ");
                    optionContinue = Console.ReadLine().ToUpper();
                }

                if (optionContinue != "S")
                    break;
            }
        }
    }
}
