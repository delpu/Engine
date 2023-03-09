using Intersect.Admin.Actions;
using MessagePack;

namespace Intersect.Network.Packets.Client
{
    [MessagePackObject]
    public partial class DropCoinPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public DropCoinPacket()
        {

        }

        public DropCoinPacket(int quantity)
        {
            Quantity = quantity;
        }

        [Key(0)]
        public int Quantity { get; set; }

    }

}
