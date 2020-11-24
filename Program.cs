using System;

namespace Ex6_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            bool search = false;

            Console.WriteLine();
            
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Por favor digite o {i+1}° nome:\n ");
                nomes[i] = Console.ReadLine().ToLower();
            }

            Console.WriteLine();
            Console.Write("Qual nome deseja procurar? ");
            string nome_digitado = Console.ReadLine().ToLower();

            foreach (string item in nomes)
            {
                if (item == nome_digitado) {
                    
                    search = true;
                }
            }

            
            if (search == true) {
                
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ACHEI");
                Console.ResetColor();
            
                }

            
            else {
                
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("NÃO ACHEI");
                Console.ResetColor();
            }

            
        }
    }
}
