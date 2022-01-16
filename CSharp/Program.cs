using System;
using CSharp;
using Interface;
using Enum;

namespace CSharp
{
    internal class Program
    {
        static double Main(string[] args)
        {
            Pessoa aluno1 = new Pessoa
            {
                Nome = "Larissa",
                Idade = 31,
                Estado = "CE"
            }

            Animal animal = new Animal
            animal.Nome = "Polly";
            animal.NomeDono = aluno1.Nome
            animal.Especie = "Cachorro"

            var pessoa0 = (Pessoas)0;
            Pessoas pessoa1 = Pessoas.Larissa;
            Pessoas pessoa2 = (Pessoas).2;

            Console.WriteLine("Hello World!");
        }
    }
}
