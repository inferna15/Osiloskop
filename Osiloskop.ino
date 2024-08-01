int pot = A0;
bool isPause = true;

void setup() {
  pinMode(pot, INPUT);
  Serial.begin(9600);
}

void loop() {
  if(Serial.available()) {
    String data = Serial.readStringUntil('\n');
    if (data == "pause") {
      isPause = true;
    }
    else {
      isPause = false;
    }
  }
  if(!isPause) {
    int potValue = analogRead(A0);
    int val = map(potValue, 0, 1023, 0, 255);
    Serial.println(val);
    delay(5);
    isPause = true;
  }
}
