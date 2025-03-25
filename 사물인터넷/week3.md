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
