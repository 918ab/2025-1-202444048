![Arduino](https://img.shields.io/badge/Arduino-00878F?style=flat-square&logo=Arduino&logoColor=white) 
 ![date](https://img.shields.io/badge/Date-2025--03--18_(week3)-green)
 <br>
![influxdb](https://img.shields.io/badge/InfluxDB-22ADF6?style=for-the-badge&logo=InfluxDB&logoColor=white)

# Influxdb

<details>
<summary>Data written to InfluxDB</summary>
<p></p>
  
```c
from influxdb_client import InfluxDBClient
import time
import serial

influxdb_url = "http://localhost:8086"
influxdb_token = "o43FgIW7oUld7KQAsQ4SZcOtjeakjll7PktYoSXP1Mv_NmYKg0Edc1F74vjhKPJUNCHUlgFD-IIDvBN1DEFADQ=="
influxdb_org = "test"
influxdb_bucket = "dust"

serial_port = "COM11"
baudrate = 9600
timeout = 2

client = InfluxDBClient(url=influxdb_url, token=influxdb_token, org=influxdb_org)
write_api = client.write_api()

try:
    ser = serial.Serial(serial_port, baudrate, timeout=timeout)
    print(f"Connected to {serial_port} at {baudrate} baud")
except serial.SerialException:
    print("Failed to connect to serial port.")
    exit()

try:
     while True:
        if ser.in_waiting > 0:
            line = ser.readline().decode('utf-8').strip()
            print(f"Received: {line}")

            if "=" in line:
                key, value = line.split("=")
                try:
                    value = float(value)
                    data = f"sensor_data,device+arduino, {key} = {value}"
                    write_api.write(bucket=influxdb_bucket,record=data)
                    print(f"Data written to InfluxDB: {key} = {value}")
                except ValurError:
                    print("invaild data format")
        time.sleep(1)
except KeyboardInterrupt:
    print("stopping data collection...")

finally:
    ser.close()
```
</details>

# Log

