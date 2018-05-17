using System;

namespace Aula10 {
    public abstract class ItemWithKarma : IHasKarma {
        private static Random r = new Random();

        public virtual float Karma { get; }

        public ItemWithKarma() {
            Karma = (float)(r.NextDouble() * 20 - 10);
        }

        public ItemWithKarma(float karma)
        {
            Karma = karma;
        }
    }
}