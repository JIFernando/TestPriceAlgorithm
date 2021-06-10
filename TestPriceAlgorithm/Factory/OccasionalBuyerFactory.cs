using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class OccasionalBuyerFactory : BuyerFactory
    {
        /*
        This kind of buyer only have the games that their friend have mostly appear 
        when there is an offer.
        */

        private const double percentaje = 0.75;

        public bool gameBought { get; set; }

        public OccasionalBuyerFactory() : base()
        {

        }

        public override bool PercentajeOfBuy(Game game, double tendence1, double tendence2)
        {
            bool willBuy = false;

            if (!gameBought)
            {
                double tendence = tendence2 - tendence1;
                
                if (tendence > 0.1)
                {
                    //Increase the price of the game
                    willBuy = rnd.Next() <= 0.1;
                }
                else if (tendence < 0.1 && tendence > -0.1)
                {
                    //La tendencia esta mas o menos igual 
                    //we can try do reduce the price of the game to increase the number of buyer of the game
                    willBuy = rnd.Next() <= 0.5;
                }
                else
                {
                    //Reduce the price of the game to increase the number of buyer of the game
                    willBuy = rnd.Next() <= 0.75;
                }
            }

            return willBuy;
        }

        public override Buyer GetBuyer()
        {
            return new OccasionalBuyer();
        }
    }
}
