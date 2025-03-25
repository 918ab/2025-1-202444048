![Arduino](https://img.shields.io/badge/Arduino-00878F?style=flat-square&logo=Arduino&logoColor=white)   ![date](https://img.shields.io/badge/Date-2025--03--25_(week3)-green)

# LCD

<details>
<summary>LCD print "Hello World"</summary>
<p></p>
  
```c
#include <LiquidCrystal_I2C.h>
#include <Wire.h>

LiquidCrystal_I2C lcd(0x27, 16, 2);

void setup(){
  lcd.init();
  lcd.backlight();
  lcd.print("LCD init");
  delay(2000);
  lcd.clear();
}

void loop(){
  lcd.setCursor(16,0);
  lcd.print("Hello, World!");

  for (int position = 0; position < 16; position++){
    lcd.scrollDisplayLeft();
    delay(150);
  }
}
```
</details>

<details>
<summary>LCD I2C 장치 찾기</summary>
<p></p>
  
```c

#include <Wire.h>

void setup()
{
  Serial.begin(9600);
  Wire.begin();
  Serial.println("I2C Running");
  
}

void loop()
{
  Serial.println("Scanning");
  for (byte address = 1;address <127; address++){
    Wire.beginTransmission(address);
    if(Wire.endTransmission() == 0){
      Serial.print("I2C 장치 발견 : 0x");
      Serial.println(address, HEX);
      delay(500);
    }
  }
  Serial.println("Scan Complete");
  delay(5000);
      
}
```
</details>

