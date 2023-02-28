using Intersect.Network.Packets.Client;

namespace Intersect.Client.Networking
{
    public static partial class PacketSender
    {
        public static void SendPlayerRunning(bool running)
        {
            Network.SendPacket(new RunningPacket(running));
        }
    }
}
