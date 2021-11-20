using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.Models
{
    // кошачьи
    public abstract class Felidae : Mammals
    {
        public virtual bool ClawsRetract { get; init; }
        public virtual bool ClimbsTrees { get; init; }
    }
}
