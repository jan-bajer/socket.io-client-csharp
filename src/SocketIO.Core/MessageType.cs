namespace SocketIO.Core
{
    public enum MessageType
    {
        Opened,
        PingProbe,
        Ping,
        PongProbe,
        Pong,
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