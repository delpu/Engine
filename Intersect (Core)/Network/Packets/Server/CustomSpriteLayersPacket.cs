using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessagePack;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public partial class CustomSpriteLayersPacket : IntersectPacket
    {

        public CustomSpriteLayersPacket()
        {
  
        }
        public CustomSpriteLayersPacket(Guid entityId, string[] customSpriteLayers)
        {
            EntityId = entityId;
            CustomSpriteLayers = customSpriteLayers;
        }

        [Key(0)]
        public string[] CustomSpriteLayers { get; set; }

        [Key(1)]
        public Guid EntityId { get; set; }
    }
}
