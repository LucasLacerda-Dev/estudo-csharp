using System;

namespace ResultadoAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            Console.Write("Aluno \nNome:");
            a.Nome = Console.ReadLine();
            Console.Write("Digite a 1º nota (máx = 30): ");
            a.Nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a 2º nota (máx = 35): ");
            a.Nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a 1º nota (máx = 35): ");
            a.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nNota Final: {0:F2}", a.NotaFinal());
            if(a.Aprovado())
                Console.WriteLine("Aprovado!");
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltou {0:F2} pontos", a.PontosNecessarios());
            }

        }
    }
}
