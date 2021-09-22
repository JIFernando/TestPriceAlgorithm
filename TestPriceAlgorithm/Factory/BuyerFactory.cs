using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public abstract class BuyerFactory 
    {
        public enum KindBuyer
        {
            Cautious = 1,
            Occasional,
            Normal,
            Compulsive,
            Aggressive,
            Random
        }

        public abstract Buyer GetBuyer();
        public abstract DateTime GetDateBuy();
        public abstract DateTime DateAppear();

        public abstract bool GameAlreadyBuy();
        public abstract bool PercentajeOfBuy(Game game, double tendence1, double tendence2, DateTime dateTime);
        public abstract KindBuyer GetBuyerType();
        //public static Random rnd = new Random();
    }
}
