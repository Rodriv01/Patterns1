using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    class CJ : AProtagonist
    {
        public override AProtagonist Clone()
        {
            return this.MemberwiseClone() as AProtagonist;
        }
    }
}
