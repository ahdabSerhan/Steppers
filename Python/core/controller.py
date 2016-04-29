import serial
import Arduino
from stepper import Stepper
class Controller(object):
    def __init__(self, port, baud ):
        self._port = port
        self._baud = baud
        self._steppers = []
        self._arduino = None

    def connect(self):
        self._serial = serial.Serial(self._port,self._baud)
        self._serial.open()
        self._arduino = Arduino(self._serial)

    def addStepper(self, stepper):
        self._steppers.append(stepper)

    def attachStepper(self, pin, step):
        stepper = Stepper(pin,step)
        self._arduino.definePin(pin,'step')
        self._steppers.append(stepper)


    def stepAllUp(self):
        for stepper in self._steppers:
            self._arduino.stepPin(stepper._pin, stepper._step)
