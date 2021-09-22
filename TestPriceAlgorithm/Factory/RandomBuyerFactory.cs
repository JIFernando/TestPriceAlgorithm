using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class RandomBuyerFactory :  BuyerFactory
    {
        /*
        This kind of buyer only have the games that their friend have mostly appear 
        when there is an offer.
        */

        private const double percentaje = 0.75;

        public bool gameBought { get; set; }
        public DateTime dateBuy { get; set; }
        public DateTime dateAppear { get; set; }
        private Random rnd = new Random();

        public RandomBuyerFactory() : base() { }

        public RandomBuyerFactory(DateTime date) : base()
        {
            dateAppear = date;
        }

        public override bool GameAlreadyBuy()
        {
            return gameBought;
        }

        public override bool PercentajeOfBuy(Game game, double tendence1, double tendence2, DateTime dateTime)
        {
            gameBought = rnd.NextDouble() <= 0.5;            

            if (gameBought)
            {
                this.dateBuy = dateTime;
            }

            return gameBought;
        }

        public override Buyer GetBuyer()
        {
            return new RandomBuyer();
        }

        public override DateTime GetDateBuy()
        {
            return dateBuy;
        }

        public override KindBuyer GetBuyerType()
        {
            return KindBuyer.Random;
        }

        public override DateTime DateAppear()
        {
            return dateAppear;
        }
    }
}
