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
        public DateTime dateBuy { get; set; }
        public DateTime dateAppear { get; set; }
        private Random rnd = new Random();

        public CautiousBuyerFactory() : base() { } 

        public CautiousBuyerFactory(DateTime date) : base()
        {
            dateAppear = date;
        }

        public override Buyer GetBuyer()
        {
            return new CautiousBuyer();
        }

        public override bool GameAlreadyBuy()
        {
            return gameBought;
        }

        public override bool PercentajeOfBuy(Game game, double tendence1, double tendence2, DateTime dateTime)
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
                    if ((dateTime - dateAppear).TotalDays < 14)
                    {
                        //La tendencia esta mas o menos igual 
                        //we can try do reduce the price of the game to increase the number of buyer of the game
                        willBuy = rnd.NextDouble() <= 0.5;
                    }
                    else
                    {
                        //La tendencia esta mas o menos igual 
                        //we can try do reduce the price of the game to increase the number of buyer of the game
                        willBuy = rnd.NextDouble() <= 0.3;
                    }
                }
                else
                {
                    //Reduce the price of the game to increase the number oif buyer of the game
                    willBuy = true;
                }

                gameBought = willBuy;
            }

            if (willBuy)
            {
                this.dateBuy = dateTime;
            }

            return willBuy;
        }

        public override DateTime GetDateBuy()
        {
            return dateBuy;
        }

        public override KindBuyer GetBuyerType()
        {
            return KindBuyer.Cautious;
        }

        public override DateTime DateAppear()
        {
            return dateAppear;
        }
    }
}
