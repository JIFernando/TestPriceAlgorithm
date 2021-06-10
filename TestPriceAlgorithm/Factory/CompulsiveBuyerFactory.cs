using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class CompulsiveBuyerFactory : BuyerFactory
    {
        /*
        This is the common fun of the game at the start they usually buy the game usually 
        when the game is just release.
        */

        private const double percentaje = 1.1;

        public bool gameBought { get; set; }

        public CompulsiveBuyerFactory() : base()
        {

        }

        public override bool PercentajeOfBuy(Game game, double tendence1, double tendence2)
        {
            bool willBuy = false;

            if (!gameBought)
            {
                double tendence = tendence2 - tendence1;

                if (tendence >= 0.3)
                {
                    //Increase the price of the game
                    willBuy = true;
                }
                else if (tendence < 0.3 && tendence > -0.1)
                {
                    //La tendencia esta mas o menos igual 
                    //we can try do reduce the price of the game to increase the number of buyer of the game
                    willBuy = rnd.Next() <= Constancts.HighCautiousPercentaje;
                }
                else
                {
                    //Reduce the price of the game to increase the number oif buyer of the game
                    willBuy = rnd.Next() <= Constancts.HighOcasionalPercentaje;
                }
            }

            return willBuy;
        }


        public override Buyer GetBuyer()
        {
            return new CompulsiveBuyer();
        }
    }
}
