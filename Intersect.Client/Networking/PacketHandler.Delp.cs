using Intersect.Client.General;
using Intersect.Network;
using Intersect.Network.Packets.Client;
using Intersect.Network.Packets.Server;

namespace Intersect.Client.Networking
{
    internal sealed partial class PacketHandler
    {
        public void HandlePacket(IPacketSender packetSender, RunningPacket packet)
        {
            if (Globals.Me != null)
            {
                Globals.Me.Running = packet.Running;
            }
        }

        public void HandlePacket(IPacketSender packetSender, InventoryCoinsUpdatePacket packet)
        {
            if (Globals.Me != null)
            {
                Globals.Me.Coins = packet.Quantity;
            }
        }
    }
}
