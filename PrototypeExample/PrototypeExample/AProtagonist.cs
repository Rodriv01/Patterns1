using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    public abstract class AProtagonist
    {
        int health;
        int felony;
        double money;

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Felony
        {
            get { return felony; }
            set { felony = value; }
        }

        public double Money
        {
            get { return money; }
            set { money = value; }
        }

        public abstract AProtagonist Clone();
    }
}
