using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Player
    {

        public string name = "aryan";
        private int health = 49;

        internal int getHealth()
        {
            return health;
        }

        internal void setHealth (int h)
        {
            health = h;
        }

    }
}
