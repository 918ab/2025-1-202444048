![Static Badge](https://img.shields.io/badge/Date-2025--03--25-green)




# LCD print
> LCD print "Hello World"
```
#include <LiquidCrystal_I2C.h>
#include <Wire.h>

LiquidCrystal_I2C lcd(0x27, 16, 2);

void setup()
{
  lcd.init();
  lcd.backlight();
  lcd.print("LCD init");
  delay(2000);
  lcd.clear();
  
}

void loop()
{
  lcd.setCursor(16,0);
  lcd.print("Hello, World!");
  
  for (int position = 0; position < 16; position++){
    lcd.scrollDisplayLeft();
    delay(150);
  }
}
```
