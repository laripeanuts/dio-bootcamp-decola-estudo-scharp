using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IAnimal
    {
        void Nome (string Nome);
        void nomeDono (string Nome);
        void Especie (string Nome);
    }

    class Animal : IAnimal
    {
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }


        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }
        void IAnimal.nomeDono(string nomeDono)
        {
            this.NomeDono = nomeDono;
        }
        void IAnimal.Especie(string especie)
        {
            this.Especie = especie;
        }
    }
}
