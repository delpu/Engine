using MessagePack;
using System;

namespace Intersect.Network.Packets.Server
{
    [MessagePackObject]
    public partial class InventoryCoinsUpdatePacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public InventoryCoinsUpdatePacket()
        {
        }

        public InventoryCoinsUpdatePacket(int quantity)
        {
            Quantity = quantity;
        }

        [Key(1)]
        public int Quantity { get; set; }

    }

}
