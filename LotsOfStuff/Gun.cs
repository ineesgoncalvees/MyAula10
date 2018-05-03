namespace Aula10
{
    /// <summary>Classe que define uma pistola</summary>
    public class Gun : IStuff
    {
        /// <summary> Peso base (variável de instância read-only)</summary>
        private readonly float baseWeight;

        /// <summary> Peso de cada bala (variável de instância read-only) </summary>
        private readonly float bulletWeight;

        /// <summary> Número de balas na arma </summary>
        public int NumberOfBullets { get; private set; }

        /// <summary> Propriedade Value, respeita o contrato com interface IValuable </summary>
        public float Value { get; }

        /// <summary> Propriedade Weight respeita o contrato com IHasWeight </summary>
        public float Weight { get { return baseWeight + NumberOfBullets * bulletWeight; } }

        /// <summary> Construtor, cria nova instância de Gun </summary>
        /// <param name="baseWeight">Peso base da arma</param>
        /// <param name="bulletWeight">Peso de cada bala</param>
        /// <param name="numberOfBullets">Número inicial de balas</param>
        /// <param name="cost">Custo da arma</param>
        public Gun(float baseWeight, float bulletWeight, int numberOfBullets, float value)
        {
            this.baseWeight = baseWeight;
            this.bulletWeight = bulletWeight;
            NumberOfBullets = numberOfBullets;
            Value = value;
        }

        /// <summary> Dispara a arma </summary>
        public void Shoot()
        {
            if (NumberOfBullets > 0)
            {
                NumberOfBullets--;
            }
        }
    }

}
