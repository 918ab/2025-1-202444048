![Arduino](https://img.shields.io/badge/Arduino-00878F?style=flat-square&logo=Arduino&logoColor=white)    ![date](https://img.shields.io/badge/Date-2025--03--11_(week2)-green)

# LED

<details>
<summary>LED Turn On/Off"</summary>
<p></p>
  
```c
#define TRIG 12
#define ECHO 11
void setup()
{
  Serial.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(TRIG, OUTPUT);
  pinMode(ECHO, INPUT);
}

void loop()
{
  long duration, distance;

  digitalWrite(TRIG, LOW);
  delayMicroseconds(2);
  digitalWrite(TRIG, HIGH);
  delayMicroseconds(10);
  digitalWrite(TRIG, LOW);
  
  duration = pulseIn(ECHO,HIGH);
  distance = duration * 17 / 1000;
  Serial.println(duration);
  Serial.print("\nDistance : ");
  Serial.print(distance);
  Serial.println(" cm");
  
  digitalWrite(LED_BUILTIN, HIGH);
  digitalWrite(7, HIGH);
  digitalWrite(8, LOW);
  delay(1000); // Wait for 1000 millisecond(s)
  digitalWrite(LED_BUILTIN, LOW);
  digitalWrite(7, LOW);
  digitalWrite(8, HIGH);
  delay(1000); // Wait for 1000 millisecond(s)
}
```
</details>

# Log
<details>
<summary>LED Turn On/Off"</summary>
<p></p>
  
* Serial
  * `Serial.begin(9600);`
  * `Serial.print("1");`
* delay
  * `delayMicroseconds(2);`
  * `delay(1000); // Wait for 1000 millisecond(s)`
* digitalWrite
  * `digitalWrite(7, LOW);`
  * `digitalWrite(8, HIGH);`
* pinMode
</details>
