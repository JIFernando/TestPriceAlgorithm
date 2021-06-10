using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPriceAlgorithm.Class
{
    public abstract class BuyerFactory 
    {
        public enum KindBuyer
        {
            Cautious = 1,
            Occasional,
            Normal,
            Compulsive,
            Aggressive
        }

        public static Random rnd = new Random();

        public abstract Buyer GetBuyer();
        public abstract bool PercentajeOfBuy(Game game, double tendence1, double tendence2);

        /*
                public Buyer abstract BuyerFactory(KindBuyer kindBuyer)
                {
                    this.kindBuyer = kindBuyer;
                    this.gameBought = false;

                    switch (this.kindBuyer)
                    {
                        case KindBuyer.Cautious:
                            return new CautiousBuyer();
                            break;
                        case KindBuyer.Occasional:
                            return new OccasionalBuyer();
                            break;
                        case KindBuyer.Normal:
                            return new NormalBuyer();
                            break;
                        case KindBuyer.Compulsive:
                            return new CompulsiveBuyer();
                            break;
                        case KindBuyer.Aggressive:
                            return new AggressiveBuyer();
                            break;
                    }
                }*/

        /*
        public abstract bool PercentajeOfBuy(Game game, double tendence1, double tendence2);/*
        {
            double probablity = 0;
            bool buy = false;

            switch (this.kindBuyer)
            {
                case KindBuyer.Cautious:
                    //They buy the game if the the price is under 50%
                    probablity = 0.5;
                    break;
                case KindBuyer.Occasional:
                    //They buy the game if the the price is under 25%
                    probablity = 0.75;
                    break;
                case KindBuyer.Normal:
                    //They buy the game in normal conditions exists a 50% 
                    probablity = 0.9;
                    break;
                case KindBuyer.Compulsive:
                    //They buy the game a 60% of the cases
                    probablity = 1.1;
                    break;
                case KindBuyer.Aggressive:
                    //They buy the game a 80% of the cases
                    probablity = 1.2;
                    break;
            }

            if (game.price <= (probablity * game.basePrice))
            {
                buy = true;
            }

            return buy;
        }*/
    }
}
