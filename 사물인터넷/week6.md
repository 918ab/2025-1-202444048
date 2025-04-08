![date](https://img.shields.io/badge/Date-2025--04--08_(week6)-green)

# Cygwin

<details>
<summary>BlinkAddpC.nc</summary>
<p></p>
  
```c
configuration BlnkAdppC
{
}

implementation
{
    components MainC, BlinkC, LedsC;
    components new TimerMillC() as Timer0;

    BlinkC -> Main.Boot;

    BlinkC.Timer0 -> Timer0;
    BlinkC.Leds -> LedsC;
}


```
</details>

# Log

</details>
