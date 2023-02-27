using MessagePack;

namespace Intersect.Network.Packets.Client
{
    [MessagePackObject]
    public partial class RunningPacket : IntersectPacket
    {
        //Parameterless Constructor for MessagePack
        public RunningPacket()
        {
        }

        public RunningPacket(bool running)
        {
            Running = running;
        }

        [Key(0)]
        public bool Running { get; set; }
    }
}
