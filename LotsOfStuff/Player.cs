namespace Aula10
{
    /// <summary>Esta classe representa um jogador num jogo</summary>
    public class Player : IHasWeight
    {

        /// <summary>Máximo de items na mochila (variável de classe, constante, implicitamente static)</summary>
        private const int maxBagItems = 4;

        /// <summary>Peso base do jogador (variável de instância, read-only) </summary>
        private readonly float baseWeight;

        /// <summary>Mochila de itens do jogador (variável de instância)</summary>
        public Bag BagOfStuff { get; }

        /// <summary> Propriedade Weight respeita o contrato com IHasWeight </summary>
        public float Weight {
            get
            {
                // Seria porreiro adicionar o peso de todas as coisas no saco
                return baseWeight;
            }
        }

        /// <summary>Construtor, cria nova instância de jogador</summary>
        /// <param name="baseWeight">Peso base do jogador</param>
        public Player(float baseWeight)
        {
            this.baseWeight = baseWeight;
            BagOfStuff = new Bag(4);
        }
    }
}
