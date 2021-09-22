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
        public DateTime dateBuy { get; set; }
        public DateTime dateAppear { get; set; }
        private Random rnd = new Random();

        public NormalBuyerFactory(): base() { }
        
        public NormalBuyerFactory(DateTime date) : base()
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

                if (tendence > 0.1)
                {
                    //Increase the price of the game
                    willBuy = rnd.NextDouble() <= 0.1;
                }
                else if (tendence < 0.1 && tendence > -0.1)
                {
                    if ((dateTime - dateAppear).TotalDays < 14)
                    {
                        //La tendencia esta mas o menos igual 
                        //we can try do reduce the price of the game to increase the number of buyer of the game
                        willBuy = rnd.NextDouble() <= Constancts.HighOcasionalPercentaje-0.2;
                    }
                    else
                    {
                        //La tendencia esta mas o menos igual 
                        //we can try do reduce the price of the game to increase the number of buyer of the game
                        willBuy = rnd.NextDouble() <= Constancts.HighOcasionalPercentaje;
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

        public override Buyer GetBuyer()
        {
            return new NormalBuyer();
        }

        public override DateTime GetDateBuy()
        {
            return dateBuy;
        }

        public override KindBuyer GetBuyerType()
        {
            return KindBuyer.Normal;
        }

        public override DateTime DateAppear()
        {
            return dateAppear;
        }
    }
}
