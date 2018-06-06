using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Program
    {
        static void Main(string[] args)
        {
            var woodenBat = new WoodenBat();
            var aluminumBat = new AluminumBat();
            var compositeBat = new CompositeBat();
            var hank = new BaseballPlayer();
            IPlayer tom = new CricketPlayer();
            tom = new BaseballPlayer();

            hank.TakeTurn(woodenBat);
            hank.TakeTurn(aluminumBat);
            hank.TakeTurn(compositeBat);

            tom.TakeTurn(woodenBat);
            tom.TakeTurn(aluminumBat);
            tom.TakeTurn(compositeBat);

        }
    }
}
