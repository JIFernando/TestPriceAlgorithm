using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class AggressiveBuyerFactory : BuyerFactory
    {        
        /*
        More aggressive when the value of the game is ingrease also ingrease the insterest 
        for the game to this kind if buyer in the value the game is reduce also is readuce 
        the interest in the game.
        */

        public bool gameBought { get; set; }

        public AggressiveBuyerFactory() : base()
        {

        }

        public override bool PercentajeOfBuy(Game game, double tendence1, double tendence2)
        {
            bool willBuy = false;

            if (!gameBought)
            {
                double tendence = tendence2 - tendence1;

                if (tendence > 0.5)
                {
                    //Increase the price of the game temor que siga subiendo
                    willBuy = true;
                }
                else if (tendence < 0.5 && tendence > -0.1)
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
            return new AggressiveBuyer();
        }
    }
}
