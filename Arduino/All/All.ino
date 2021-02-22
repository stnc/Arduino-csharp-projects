

int ledState = 0;

 const byte pirPin = 2;
const byte pirLED = 13; // buildin LED
const byte pirLED2 = 8; // optional second LED ??
byte calibrationTime = 5;
boolean pirState = 0, oldpirState = 0;

void setup()
{
  pinMode(pirLED, OUTPUT);

  Serial.begin(9600);
}
void loop()
{
  char receiveVal;

  if (Serial.available() > 0)
  {
    receiveVal = Serial.read();

    if (receiveVal == '1') {
      ledState = 1;
    }
    else if (receiveVal == '0') {
      ledState = 0;
    }
    else if (receiveVal == 'pir') {
      pir();
    }
  }

  digitalWrite(pirLED, ledState);

  delay(50);
}

void pir() {
  pirState = digitalRead(pirPin); // read the pin every loop
  if (pirState != oldpirState) { // if it has changed (not the same as before)
    if (pirState) { // if PIR is active
      digitalWrite(pirLED, HIGH); // turn onboard LED on
      Serial.println("Movement detected");
      // more "on" code here, e.g. send alarm to BT/Android
    }
    else { // if PIR is not active
      digitalWrite(pirLED, LOW); // turn onboard LED off
      Serial.println("PIR inactive");
      // more "off" code here
    }
    oldpirState = pirState; // update oldpirState
  }
}
