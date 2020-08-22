using System;

namespace ExercicioClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            velha.*/
            var primeiraPessoa = new Pessoa ();
            var segundaPessoa = new Pessoa();


            Console.WriteLine("Digite nome e idade:");
            primeiraPessoa.nome=Console.ReadLine();
            primeiraPessoa.idade=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro nome e idade:");
            primeiraPessoa.nome = Console.ReadLine();
            primeiraPessoa.idade = int.Parse(Console.ReadLine());

            if (primeiraPessoa.idade > segundaPessoa.idade)
            {
                Console.WriteLine($"A pessoa mais velha é: {primeiraPessoa.nome}");
            }
            else
            {
                Console.WriteLine($"A pessoa mais velha é: {segundaPessoa.nome}");
            }
        }
    }
}
