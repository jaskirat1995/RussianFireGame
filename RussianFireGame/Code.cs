using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RussianFireGame
{

    abstract class done {
        public void load() {
        }
    }
   public class Code
    {
        Random rndobject=new Random();
        public String load() {
            return "RussianLoad.gif";
        }
        public String Spin()
        {
            return "RussianSpin.gif";
        }
        public string Shoot() {
            return "RussianFire.gif";
        }
        public int fire() {
            int y = rndobject.Next(1, 6);
            for (int x=1;x<=6;x++) {
                if (x==y) {
                    break;
                }
            }
            return y;
        }

        public int Scndfire()
        {
            int y = rndobject.Next(1, 6);
            for (int x = 1; x <= 6; x++)
            {
                if (x == y)
                {
                    break;
                }
            }
            return y;
        }


    }
}
