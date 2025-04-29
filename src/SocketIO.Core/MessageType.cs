namespace SocketIO.Core
{
    public enum MessageType
    {
        Opened,
        Ping,
        Pong,
        PingProbe,
        PongProbe,
        Upgrade,
        Connected,
        Disconnected,
        Event,
        Ack,
        Error,
        Binary,
        BinaryAck
    }
}