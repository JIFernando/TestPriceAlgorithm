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
        public DateTime dateBuy { get; set; }
        public DateTime dateAppear { get; set; }
        private Random rnd = new Random();

        public AggressiveBuyerFactory() : base() { }

        public AggressiveBuyerFactory(DateTime date) : base()
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

                if (tendence > 0.5)
                {
                    //Increase the price of the game temor que siga subiendo
                    willBuy = true;
                }
                else if (tendence < 0.5 && tendence > -0.1 && (dateTime - dateAppear).TotalDays < 14)
                {
                    if ((dateTime - dateAppear).TotalDays < 14)
                    {
                        //La tendencia esta mas o menos igual 
                        //we can try do reduce the price of the game to increase the number of buyer of the game
                        willBuy = rnd.NextDouble() <= 0.9;
                    }
                    else
                    {
                        //La tendencia esta mas o menos igual 
                        //we can try do reduce the price of the game to increase the number of buyer of the game
                        willBuy = rnd.Next(0, 1) <= 0.3;
                    }
                }
                else
                {
                    //Reduce the price of the game to increase the number oif buyer of the game
                    willBuy = rnd.Next(0, 1) <= Constancts.HighOcasionalPercentaje;
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
            return new AggressiveBuyer();
        }

        public override DateTime GetDateBuy()
        {
            return dateBuy;
        }

        public override KindBuyer GetBuyerType()
        {
            return KindBuyer.Aggressive;
        }
        
        public override DateTime DateAppear()
        {
            return dateAppear;
        }
    }
}
