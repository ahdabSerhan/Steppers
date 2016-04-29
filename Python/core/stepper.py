class Stepper(object):
    def __init__(self, pin, step, tag):
        self._pin = pin
        self._position = 0
        self._step = step
        self._tag = tag

    def stepUp(self):
        self._position = self._position + self._step

    def stepDown(self):
        self._position = self._position - self._step