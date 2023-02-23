using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Intersect.GameObjects;

namespace Intersect.Server.Entities
{
    public partial class Entity
    {
        public bool IgnoreOnMoveSpell()
        {
            if(SpellCastSlot < 0)
            {
                return false;
            }

            var descriptor = SpellBase.Get(Spells[SpellCastSlot].SpellId);

            if (descriptor == null)
            {
                return false;
            }

            return descriptor.IgnoreCancelOnMoving;
        }
    }
}
