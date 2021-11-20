using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.Models.Mammal
{
    // Парнокопытные
    public abstract class Artiodactyls : Mammals
    {
        public virtual bool Horns { get; set; }
        public virtual bool OddNumberOfFingers { get; set; }
        public virtual bool Ruminant { get; set; }
    }
}
