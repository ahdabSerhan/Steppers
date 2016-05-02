using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppersController
{
    class Encoder
    {
  
        public byte[] SetPinPacket(int pin, Arduino.PinType pType)
        {
            return encode((byte)Arduino.Opcode.Set,(byte)pin,(byte)pType);
        }
        public byte[] MoveAllPacket(byte pins, Arduino.Direction direction)
        {
            return encode((byte)Arduino.Opcode.MoveAll, pins,(byte)direction);
        }

        public byte[] MoveStepperPacket(int pin, Arduino.Direction direction)
        {
            return encode((byte)Arduino.Opcode.Move, (byte)pin, (byte)direction);
        }

        public byte[] SetStepSizePacket(int stepSize)
        {
            return null;
        }

        public byte[] addStepper(int pin)
        {
            return null;
        }

        private byte[] encode(byte b1, byte b2, byte b3)
        {
            return new byte[] { (byte)'S', b1, b2, b3, (byte)'E' };
        }
    }
}
