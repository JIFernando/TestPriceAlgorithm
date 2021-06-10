using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPriceAlgorithm.Class;

namespace TestPriceAlgorithm.Factory
{
    public class CautiousBuyerFactory: BuyerFactory
    {
        /*        
        This kind of buyer rearly buy a game usually exist the posibility that if everyone is 
        buying the game they buy it, but is more posible in the case that the prease decrase a
        lot.
        */
        public bool gameBought { get; set; }

        public CautiousBuyerFactory() { }

        public override Buyer GetBuyer()
        {
            return new CautiousBuyer();
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
                else if (tendence < 0.1 && tendence > -0.5)
                {
                    //La tendencia esta mas o menos igual 
                    //we can try do reduce the price of the game to increase the number of buyer of the game
                    willBuy = rnd.Next() <= 0.4;
                }
                else
                {
                    //Reduce the price of the game to increase the number oif buyer of the game
                    willBuy = true;
                }
            }

            return willBuy;
        }
    }
}
