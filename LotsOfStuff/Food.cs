namespace Aula10
{
    /// <summary>Classe que define um pedaço de comida</summary>
    public class Food : IStuff
    {
        /// <summary> Dias que a comida tem (variável de instância)</summary>
        private float days;

        /// <summary> Tipo de comida (propriedade read-only) </summary>
        public FoodType Type { get; }

        /// <summary> Propriedade Value, respeita o contrato com interface IValuable </summary>
        public float Value
        {
            get
            {
                // O custo da comida depende do valor inteiro dado ao tipo de comida na
                // enumeração FoodType sobre o número de dias que a comida tem (quanto
                // mais dias, menos vale)
                return (int)Type / (days + 1);
            }
        }

        /// <summary> Propriedade Weight respeita o contrato com IHasWeight </summary>
        public float Weight { get; }

        /// <summary> Construtor, cria nova instância de Food </summary>
        /// <param name="type">Tipo de comida (definido na enumeração FoodType)</param>
        /// <param name="days">Número de dias que a comida tem</param>
        /// <param name="weight">Peso da comida</param>
        public Food(FoodType type, float days, float weight)
        {
            this.days = days;
            Type = type;
            Weight = weight;
        }

    }
}
