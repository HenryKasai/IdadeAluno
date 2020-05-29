using System;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nascimento = new DateTime(2004, 4, 12, 00, 00, 00);
            string longdate = nascimento.ToLongDateString();
            DateTime aniversário = nascimento.AddYears(18);
            string longdateaniversario = aniversário.ToLongDateString();
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Eu nasci em {longdate}.");
            Console.WriteLine($"Aniversário de 18 anos em {longdateaniversario}.");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
