using System.Globalization;

namespace JogoDeAdivinhacao.ConsoleApp.Entities.Utils
{
    class Auxiliary
    {
        public static int IntVerify(string prompt, string inputError)
        {
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine($"\nAcho que isso não é um número...\n");
                    continue;
                }
                try
                {
                    if (input.Trim().Contains(',') || input.Trim().Contains('.') || input.Trim().Contains(' '))
                    {
                        throw new Exception("\nO valor não pode conter espaço ' ', ponto (.), ou vírgula (,)!\n");
                    }
                    int n = Convert.ToInt32(input, CultureInfo.InvariantCulture);

                    if (n <= 0)
                    {
                        throw new Exception("O número não pode ser negativo!");
                    }
                    return n;
                }
                catch (FormatException)
                {
                    Console.WriteLine(inputError);
                    continue;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"\nAlgo deu errado... {e.Message}");
                    continue;
                }
            } while (true);
        }
        public static string OptionVerify(string prompt, string[] options)
        {
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine()!;

                if (input == null)
                {
                    Console.WriteLine($"\nAcho que isso não é uma opção...");
                    continue;
                }
                input = input.Trim().ToUpper();
                for (int i = 0; i < options.Length; i++)
                {
                    if (input == options[i])
                    {
                        return input;
                    }
                }

                Console.WriteLine($"Acredito que ({input}) não é uma das opções...");
            } while (true);
        }
    }
}
