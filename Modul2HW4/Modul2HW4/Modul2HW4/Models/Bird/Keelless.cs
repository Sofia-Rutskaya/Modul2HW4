using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW4.Models.Bird
{
    // Бескилевые
    public abstract class Keelless : Birds
    {
        public override bool AbilityToFly { get; init; } = false;
        public virtual bool Keel { get; init; }
    }
}
