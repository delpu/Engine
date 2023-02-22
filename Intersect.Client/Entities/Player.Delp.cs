using System;
using Intersect.GameObjects;

namespace Intersect.Client.Entities
{
    public partial class Player
    {
        public bool IgnoreOnMoveSpell()
        {
            var descriptor = SpellBase.Get(SpellCast);

            if(descriptor == null)
            {
                return false;
            }

            return descriptor.IgnoreCancelOnMoving;
        }
    }
}
