using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersect.Network.Packets.Server
{

    public partial class CustomSpriteLayersPacket : IntersectPacket
    {

        public CustomSpriteLayersPacket(Guid entityId, string[] customSpriteLayers)
        {
            EntityId = entityId;
            CustomSpriteLayers = customSpriteLayers;
        }

        public string[] CustomSpriteLayers { get; set; }

        public Guid EntityId { get; set; }
    }
}
