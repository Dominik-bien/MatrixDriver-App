#include <MD_Parola.h> 
#include <MD_MAX72xx.h> 
#include <SPI.h> 
#define HARDWARE_TYPE MD_MAX72XX::FC16_HW 
#define MAX_DEVICES 4 
#define CS_PIN 10 
MD_Parola myDisplay(HARDWARE_TYPE, CS_PIN, MAX_DEVICES); 
char receivedText[100] = {0}; 
uint8_t textIndex = 0; 
String defaultText = "Projekt MiM - Dominik Bien"; 
void resetToFactory() { 
  myDisplay.displayClear(); 
  myDisplay.displayScroll(defaultText.c_str(), PA_CENTER, PA_SCROLL_LEFT, 
200); 
} 
 
void setup() { 
  Serial.begin(9600); 
  myDisplay.begin(); 
  myDisplay.setIntensity(4); 
  resetToFactory(); 
} 
 
void loop() { 
  if (Serial.available() > 0) { 
    char c = Serial.read(); 
     
    if (c == '\n') { 
      receivedText[textIndex] = '\0'; 
 
      if (strcmp(receivedText, "RESET") == 0) { 
        resetToFactory();  
      } 
 
      else if (textIndex >= 2 && receivedText[1] == ':') { 
        char effect = receivedText[0]; 
        char* text = receivedText + 2; 
         
        myDisplay.displayClear(); 
         
        switch(effect) { 
          case 'L': // SCROLL LEFT 
          myDisplay.displayScroll((strlen(text) > 0 ? text : 
defaultText.c_str()), PA_CENTER, PA_SCROLL_LEFT, 200); 
          break; 
 
          case 'R': // SCROLL RIGHT 
          myDisplay.displayScroll((strlen(text) > 0 ? text : 
defaultText.c_str()), PA_CENTER, PA_SCROLL_RIGHT, 200); 
          break; 
 
          case 'U': // SCROLL UP 
          myDisplay.displayScroll((strlen(text) > 0 ? text : 
defaultText.c_str()), PA_CENTER, PA_SCROLL_UP, 200); 
          break; 
 
          case 'D': //SCROLL DOWN
           myDisplay.displayScroll((strlen(text) > 0 ? text : 
defaultText.c_str()), PA_CENTER, PA_SCROLL_DOWN, 200);  
           break; 
 
          case 'B': // BLINK 
          myDisplay.displayText((strlen(text) > 0 ? text : 
defaultText.c_str()), PA_CENTER, 1000, 0, PA_PRINT, PA_PRINT); 
          break; 
 
          case 'F': //FADE
          myDisplay.displayText((strlen(text) > 0 ? text : 
defaultText.c_str()), PA_CENTER, 200, 0, PA_FADE, PA_FADE); 
          break;  
           
          case 'O': // OPENING 
          myDisplay.displayText((strlen(text) > 0 ? text : 
defaultText.c_str()), PA_CENTER, 200, 0, PA_OPENING, PA_OPENING); 
          break; 
 
          case 'C': // CLOSING 
          myDisplay.displayText((strlen(text) > 0 ? text : 
defaultText.c_str()), PA_CENTER, 200, 0, PA_CLOSING, PA_CLOSING); 
          break; 
 
          case 'M': // MESH 
          myDisplay.displayText((strlen(text) > 0 ? text : 
defaultText.c_str()), PA_CENTER, 200, 0, PA_MESH, PA_MESH); 
          break; 
 
} 
      } 
      textIndex = 0; 
    }  
    else if (c != '\r' && textIndex < sizeof(receivedText)-1) { 
      receivedText[textIndex++] = c; 
    } 
  } 
 
  if (myDisplay.displayAnimate()) { 
    myDisplay.displayReset(); 
  } 
}