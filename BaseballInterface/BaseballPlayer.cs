using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
   public class BaseballPlayer: IPlayer
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public void TakeTurn(IBaseballBat bat)
        {
            bat.Swing();
        }

    }

}
