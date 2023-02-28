using Intersect.Network;
using Intersect.Network.Packets.Client;
using Intersect.Server.Entities;

namespace Intersect.Server.Networking
{
    public static partial class PacketSender
    {
        public static void SendPlayerRunning(Player player, bool running)
        {
            if (player == null) return;
            player.SendPacket(new RunningPacket(running), TransmissionMode.Any);
        }
    }
}
