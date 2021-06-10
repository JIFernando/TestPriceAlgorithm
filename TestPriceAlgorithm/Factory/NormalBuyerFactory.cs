using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public class NormalBuyerFactory : BuyerFactory
    {
        /*
        Normal kind of buyer is more posible that this king of buyer buy de game in the mean time.
        */

        public bool gameBought { get; set; }

        public NormalBuyerFactory(): base ()
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
                    willBuy = false;
                }
                else if (tendence < 0.1 && tendence > -0.1)
                {
                    //La tendencia esta mas o menos igual 
                    //we can try do reduce the price of the game to increase the number of buyer of the game
                    willBuy = (1 - rnd.Next()) <= Constancts.HighOcasionalPercentaje;
                }
                else
                {
                    //Reduce the price of the game to increase the number oif buyer of the game
                    willBuy = true;
                }
            }

            return willBuy;
        }

        public override Buyer GetBuyer()
        {
            return new NormalBuyer();
        }
    }
}
