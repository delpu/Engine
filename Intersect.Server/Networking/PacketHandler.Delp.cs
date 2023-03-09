using Intersect.Network.Packets.Client;

namespace Intersect.Server.Networking
{
    internal sealed partial class PacketHandler
    {
        public void HandlePacket(Client client, RunningPacket packet)
        {
            var player = client?.Entity;
            if (player == null) return;

            player.Running = packet.Running;
            PacketSender.SendPlayerRunning(player, packet.Running);
        }

        //DirectionPacket
        public void HandlePacket(Client client, DropCoinPacket packet)
        {
            var player = client?.Entity;
            if (player == null) return;

            player.DropCoin(packet.Quantity);
        }
    }
}
