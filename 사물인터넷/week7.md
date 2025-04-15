![Arduino](https://img.shields.io/badge/Arduino-00878F?style=flat-square&logo=Arduino&logoColor=white)  ![date](https://img.shields.io/badge/Date-2025--04--15_(week7)-green)

# Timer

<details>
<summary>loop (if)</summary>
<p></p>
  
```c
void setup() {
  Serial.begin(115200);
  Serial.println();
}
void loop() {
  static unsigned long loopCnt = 0;
  static unsigned long nextMil = millis() + 1000;
  loopCnt++;
  if (millis() > nextMil) {
    nextMil = millis() + 1000;
    Serial.println(loopCnt);
    loopCnt = 0;
  }
}

```
</details>
<details>
<summary>loop (SimpleTimer.h)</summary>
<p></p>
  
```c
#include <SimpleTimer.h>
SimpleTimer timerCnt;

unsigned long loopCnt;

void timerCntFunc(){
  Serial.println(loopCnt);
  loopCnt = 0;
}

void setup() {
  Serial.begin(115200);
  Serial.println();
  timerCnt.setInterval(1000,timerCntFunc);
}
void loop(){
  timerCnt.run();
  loopCnt++;
}
```
</details>

# Function

<details>
<summary>void sum</summary>
<p></p>
  
```c
int a1 = 2;
int a2 = 3;
int a3;

void setup(){
  Serial.begin(115200);
  Serial.println();

  //아래 a1, a2, a3는 인수(argument)임
  sum(a1,a2,a3);
  Serial.println(a3);
}

void loop(){

}

void sum(int a, int b, int& c){
  c = a + b;
}

```
</details>

</details>

# Class

<details>
<summary>LedToggle.h</summary>
<p></p>
  
```c
#ifndef LegToggle_h
#define LedToggle_h

#include "Arduino.h"
class LegToggle{
  public:
        LegToggle(int pin);
        void toggle();
  private:
          int _pin;
          bool _state;
};
#endif

```
</details>
<details>
<summary>LegToggle.cpp</summary>
<p></p>
  
```c
#include "LedToggle.h"

LegToggle::LegToggle(int pin){
  _pin = pin;
  _state = false;
  pinMode(_pin,OUTPUT);
  digitalWrite(_pin,LOW);
}
void LegToggle::toggle(){
  _state = !_state;
  digitalWrite(_pin, _state ? HIGH : LOW);
}

```
</details>


# Log
* static
  * `static unsigned long loopCnt = 0;`
  * `static unsigned long nextMil = millis() + 1000;`
* SimpleTimer timerCnt
  * `timerCnt.setInterval(1000,timerCntFunc);`
  * `timerCnt.run();`
</details>
