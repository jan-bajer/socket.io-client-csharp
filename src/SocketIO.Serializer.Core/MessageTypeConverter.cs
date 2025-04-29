using SocketIO.Core;
using System;

namespace SocketIO.Serializer.Core
{
    public class MessageTypeConverter
    {
        private const string OPENED = "0";
        private const string PING = "2";
        private const string PONG = "3";
        private const string PING_PROBE = "2probe";
        private const string PONG_PROBE = "3probe";
        private const string UPGRADE = "5";
        private const string CONNECTED = "40";
        private const string DISCONNECTED = "41";
        private const string EVENT = "42";
        private const string ACK = "43";
        private const string ERROR = "44";
        private const string BINARY = "45";
        private const string BINARY_ACK = "46";

        public static MessageType FromString(string messageType)
        {
            switch (messageType)
            {
                case OPENED:
                    return MessageType.Opened;
                case PING:
                    return MessageType.Ping;
                case PONG:
                    return MessageType.Pong;
                case PING_PROBE:
                    return MessageType.PingProbe;
                case PONG_PROBE:
                    return MessageType.PongProbe;
                case UPGRADE:
                    return MessageType.Upgrade;
                case CONNECTED:
                    return MessageType.Connected;
                case DISCONNECTED:
                    return MessageType.Disconnected;
                case EVENT:
                    return MessageType.Event;
                case ACK:
                    return MessageType.Ack;
                case ERROR:
                    return MessageType.Error;
                case BINARY:
                    return MessageType.Binary;
                case BINARY_ACK:
                    return MessageType.BinaryAck;
                default:
                    throw new ArgumentException($"Unknown message type: {messageType}");
            }
        }

        public static string ToString(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Opened:
                    return OPENED;
                case MessageType.Ping:
                    return PING;
                case MessageType.Pong:
                    return PONG;
                case MessageType.PingProbe:
                    return PING_PROBE;
                case MessageType.PongProbe:
                    return PONG_PROBE;
                case MessageType.Upgrade:
                    return UPGRADE;
                case MessageType.Connected:
                    return CONNECTED;
                case MessageType.Disconnected:
                    return DISCONNECTED;
                case MessageType.Event:
                    return EVENT;
                case MessageType.Ack:
                    return ACK;
                case MessageType.Error:
                    return ERROR;
                case MessageType.Binary:
                    return BINARY;
                case MessageType.BinaryAck:
                    return BINARY_ACK;
                default:
                    throw new ArgumentException($"Unknown message type: {messageType}");
            }
        }
    }
}
