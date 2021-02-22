 const byte pirPin = 2;
const byte pirLED = 13; // buildin LED

byte calibrationTime = 5;
boolean pirState = 0, oldpirState = 0;

void setup() {
  Serial.begin(9600); // start serial monitor
  pinMode(pirLED, OUTPUT);

  Serial.print("Calibrating");

  for (int i = 0; i < calibrationTime; i++) {
    Serial.print(".");
    delay(1000);
  }
  Serial.println(" done");
  Serial.println("SENSOR ACTIVE");
}

void loop() {
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
 
