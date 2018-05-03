using System;
using System.Collections;

namespace Aula10
{
    /// <summary>Programa para testar o projeto</summary>
    public class Program
    {
        /// <summary>O programa começa aqui no Main</summary>
        /// <param name="args">Ignoramos os argumentos de linha de comandos neste programa</param>
        public static void Main(string[] args)
        {
            // Criar uma nova instância de Program e
            // invocar o método TestProjet na instância criada
            Program prog = new Program();
            prog.TestProject();

        }

        /// <summary>Método que testa este projeto</summary>
        private void TestProject()
        {
            // Instanciar um jogador com 70 quilos
            Player p = new Player(70.0f);

            //
            // Adicionar vários itens à mochila do jogador:
            //

            // Pão com 2 dias, 500 gramas
            p.BagOfStuff.AddThing(new Food(FoodType.Bread, 2, 0.500f));
            // 300 gramas de vegetais com 5 dias
            p.BagOfStuff.AddThing(new Food(FoodType.Vegetables, 5, 0.300f));
            // Pistola com 1.5kg + 50 gramas por bala, carregada com 10 balas, com um custo de 250€
            p.BagOfStuff.AddThing(new Gun(1.5f, 0.050f, 10, 250));
            // 200 gramas de fruta fresca
            p.BagOfStuff.AddThing(new Food(FoodType.Fruit, 0, 0.200f));

            // Quantos itens tem o jogador na mochila?
            Console.WriteLine($"Nº de itens na mochila: {p.BagOfStuff.StuffCount}");

            // Percorrer itens na mochila e tentar "imprimir" cada um
            for (int i = 0; i < p.BagOfStuff.StuffCount; i++)
            {
                IStuff aThing = p.BagOfStuff.GetThing(i);
                Console.WriteLine(aThing);
            }

        }
    }
}
