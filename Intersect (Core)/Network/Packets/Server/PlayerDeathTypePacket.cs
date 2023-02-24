using Intersect.GameObjects.Events;
using MessagePack;
using System.Collections.Generic;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public class PlayerDeathTypePacket : IntersectPacket
    {
        public PlayerDeathTypePacket()
        {
        }

        public PlayerDeathTypePacket(DeathType type)
        {
            Type = type;
        }

        [Key(0)]
        public DeathType Type = DeathType.PvE;

    }
}
