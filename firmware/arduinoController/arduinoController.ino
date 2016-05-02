#define SET 1
#define MOVE 2
#define READ 3
#define ALL 4

char buff[5] = { 100, 100, 100, 100, 100 };
int i = 0;
void setup() {
  Serial.begin(9600);
}

void readPin(char pin) {
  Serial.println("reading pin");
}
void definePin(char pin, char ptype) {
  pinMode(pin, ptype);
  Serial.println("Defining pin");
}

void moveStepper(char pin, char duration) {

}
void resolve() {
  switch (buff[1]) {
    case SET: definePin(buff[2], buff[3]); break;
    case MOVE: moveStepper(buff[2], buff[3]); break;
    case READ: readPin(buff[2]); break;
    case ALL: readPin(buff[2]); break;
  }
}
char c;
void loop() {
  if (Serial.available()) {
    c = Serial.read();
    for (i = 0; i < 4; i++) {
      buff[i] = buff[i + 1];
    }
    buff[4] = c;
    if (buff[0] == 'S' && buff[4] == 'E') {
      Serial.println("resolved");
      // resolve();
    }
  }
}

