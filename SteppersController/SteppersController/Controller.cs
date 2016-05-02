using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteppersController
{
    class Controller
    {
        public List<Stepper> steppers = new List<Stepper>();
        public Arduino arduino = new Arduino();
        public Encoder encoder = new Encoder();
        
        public void connect(string port, int baud)
        {
            arduino.connect(port, baud);
        }
        public void disconnect()
        {
            arduino.disconnect();
            arduino = null;
        }

        public void moveAll(Arduino.Direction direction, Arduino.Step step)
        {
            byte[] packet = encoder.MoveAllPacket(0x0F, direction);
            arduino.sendPacket(packet);
        }
        public void moveStepper(Stepper stepper, Arduino.Direction direction, int step)
        {
            byte[] packet = encoder.MoveAllPacket(0x0F, direction);
            arduino.sendPacket(packet);
        }

        public void SetStepSize(int stepSize)
        {

        }

        public void definePin(int pin, Arduino.PinType ptype)
        {
            byte[] packet = encoder.SetPinPacket(pin, ptype);
            arduino.sendPacket(packet);
        }

        public void readPin()
        {

        }
        public void addStepper(int pin)
        {
            Stepper s = new Stepper();
            s.pin = pin;
            s.position = 0;
            s.id = pin;
            s.tag = "Stepper " + pin;
            s.active = true;
            this.steppers.Add(s);
        }

    }
}
