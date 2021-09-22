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
        public DateTime dateBuy { get; set; }
        public DateTime dateAppear { get; set; }
        private Random rnd = new Random();

        public CompulsiveBuyerFactory() : base() { }

        public CompulsiveBuyerFactory(DateTime date) : base()
        {
            dateAppear = date;
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

                if (tendence >= 0.3)
                {
                    //Increase the price of the game
                    willBuy = true;
                }
                else if (tendence < 0.3 && tendence > -0.1)
                {
                    if ((dateTime - dateAppear).TotalDays < 14)
                    {
                        //La tendencia esta mas o menos igual 
                        //we can try do reduce the price of the game to increase the number of buyer of the game
                        willBuy = rnd.NextDouble() <= 0.6;
                    }
                    else
                    {
                        //La tendencia esta mas o menos igual 
                        //we can try do reduce the price of the game to increase the number of buyer of the game
                        willBuy = rnd.NextDouble() <= 0.5;
                    }
                }
                else
                {
                    //Reduce the price of the game to increase the number oif buyer of the game
                    willBuy = rnd.NextDouble() <= Constancts.HighOcasionalPercentaje;
                }

                gameBought = willBuy;
            }

            if (willBuy)
            {
                this.dateBuy = dateTime;
            }

            return willBuy;
        }


        public override Buyer GetBuyer()
        {
            return new CompulsiveBuyer();
        }

        public override DateTime GetDateBuy()
        {
            return dateBuy;
        }

        public override KindBuyer GetBuyerType()
        {
            return KindBuyer.Compulsive;
        }

        public override DateTime DateAppear()
        {
            return dateAppear;
        }
    }
}
