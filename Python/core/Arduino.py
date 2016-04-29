class Arduino(object):
    def __init__(self, serial):
        self._serial = serial
        self._modes = {
            'out': 1,
            'in': 2,
            'step': 3
        }
        self._operations = {
            'define': 1,
            'write': 2,
            'read': 3
        }

    def definePin(self, pin, type):
        self.write([self._operations['define'],pin,self._modes[type]])

    def changePin(self, pin, value):
        self.write([self._operations['write'],pin,value])

    def stepPn(self, pin, dir, step):
        self.write([self._operations['write'],pin,dir,step])

    def readPin(self, pin, type):
        self.write([self._operations['read'],pin,self._modes[type]])

    def write(self, data):
        self._serial.write(chr(200))
        for d in data:
            self._serial.write(chr(d))
        self._serial.write(chr(200))
