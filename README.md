# MatrixDriver-App
My first project using an Arduino Uno and a 32x8 MAX7219 LED matrix, with animation control managed through a WinForms application

## 🛠️ Technologies
- Arduino UNO
- MAX7219 32x8 LED matrix
- C# WinForms
-  Serial communication
 
 ## 📂 Project Structure
 -Arduino – Arduino code
 -Application - Windows application project
 -imagesAndVideo - Images and videos 

## 🚀 How It Works

1. The Arduino reads commands via the serial port.
2. The C# application sends user input to Arduino to display text and animation text change
3. CA simple protocol is used to communicate between the PC and the Arduino


## 🧰 Planned Features
- Add a basic temperature and humidity sensor (DHT11)
- Display sensor data in real-time on a chart in the WinForms application
- Add a warning diode (LED) that lights up when temperature exceeds a threshold
- Display temperature and humidity on the LED matrix
- Migrate from WinForms to WPF or .NET MAUI for improved UI and portability
