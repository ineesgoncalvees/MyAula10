using System;

namespace Aula10
{
    /// <summary>Classe que representa uma mochila ou saco que contem itens</summary>
    public class Bag
    {
        /// <summary>Array que contém os itens da mochila</summary>
        private IStuff[] stuff;

        /// <summary>Número de itens na mochila</summary>
        public int StuffCount { get; private set; }

        /// <summary>Construtor que cria uma nova instância de mochila</summary>
        /// <param name="bagSize">Número máximo de itens que é possível colocar na mochila</param>
        public Bag(int bagSize)
        {
            stuff = new IStuff[bagSize];
            StuffCount = 0;
        }

        /// <summary>Colocar um item na mochila</summary>
        /// <param name="aThing">Item a colocar na mochila</param>
        public void AddThing(IStuff aThing)
        {
            // Será que temos espaço na mochila?
            if (StuffCount >= stuff.Length)
            {
                // Senão tivermos podemos "lançar" uma exceção
                throw new InvalidOperationException("Bag is already full!");
            }

            // Adicionar o item à mochila e depois incrementar o
            // número de coisas na mochila
            stuff[StuffCount++] = aThing;
        }

        /// <summary>Observar um item da mochila sem o remover da mesma</summary>
        /// <param name="index">Local onde está o item a observar</param>
        /// <returns>Item a ser observado</returns>
        public IStuff GetThing(int index)
        {
            if (index >= StuffCount)
            {
                // Senão existir um item no local indicado, "lançar" uma exceção
                throw new InvalidOperationException("Bag doesn't have that much stuff!");
            }
            return stuff[index];
        }
    }
}
