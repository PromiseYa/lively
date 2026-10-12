using System;

namespace Lively.Models.Message
{
    /// <summary>
    /// Forward a mouse wheel gesture to the web page.
    /// X/Y are physical screen coordinates, Delta is the signed wheel delta (multiples of 120).
    /// </summary>
    [Serializable]
    public class LivelyWheelCmd : IpcMessage
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Delta { get; set; }

        public LivelyWheelCmd() : base(MessageType.cmd_wheel)
        {
        }
    }
}
