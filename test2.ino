//Piano Test Sketch Using arduino + Port Expander ic mcp23017  
// 0 1000 1 100 2 100 3 100 4 100 5 100 6 100 7 100 8 100 9 100 10 100 11 100 12 100 13 100 14 100
#include <Wire.h>
#include "Adafruit_MCP23017.h"

Adafruit_MCP23017 mcp;
Adafruit_MCP23017 mcp1;
Adafruit_MCP23017 mcp2;  
Adafruit_MCP23017 mcp3; 
int k;
int t;
int notes[500];
 
void setup() { 
  Serial.begin(9600);
  mcp.begin();      // use default address 0
  for(int i = 0; i <= 15; i++)
    {
        mcp.pinMode(i, OUTPUT);  
        mcp.digitalWrite(i, LOW);              
    }


  mcp1.begin(1);   
  for(int i = 0; i <= 15; i++)
    {    
        mcp1.digitalWrite(i, LOW);
        mcp1.pinMode(i, OUTPUT); 
    } 

  mcp2.begin(2);   
  for(int i = 0; i <= 15; i++)
    {    
        mcp2.digitalWrite(i, LOW);
        mcp2.pinMode(i, OUTPUT); 
    } 
    
  mcp3.begin(3);   
  for(int i = 0; i <= 15; i++)
    {    
        mcp3.digitalWrite(i, LOW);
        mcp3.pinMode(i, OUTPUT); 
    } 
}


//void loop() {
//    while(Serial.available() == 0) {}
//    k = Serial.parseInt();
//    t = Serial.parseInt();
//    if (k >= 0 && k <=15) {
//      mcp.digitalWrite(k, HIGH);
//      delay(t);
//      mcp.digitalWrite(k, LOW);
//    }
//    else if (k >= 16 && k <= 31) {
//      mcp1.digitalWrite(k-16, HIGH);
//      delay(t);
//      mcp1.digitalWrite(k-16, LOW);
//    }
//    else if (k >= 32 && k <= 47)  {
//      mcp2.digitalWrite(k-32, HIGH);
//      delay(t);
//      mcp2.digitalWrite(k-32, LOW);
//    }
//    else {
//      mcp3.digitalWrite(k-48, HIGH);
//      delay(t);
//      mcp3.digitalWrite(k-48, LOW);
//    }
//}


void loop() {
//  while(Serial.available() == 0) {}
//  k = Serial.parseInt();
//  Serial.println(k);
  if (Serial.available())
  {
    int i =0;
    while(Serial.available() && i < 500)
    {
      k = Serial.parseInt();
      notes[i] = k;
      i++;
    }
    Serial.end();
    Serial.begin(9600);
    for (int j=0; j<500; j=j+2) {
      k = notes[j] - 21;
      t = notes[j+1] ;
      Serial.println(k);
      Serial.println(t);
      if (k >= 0 && k <=15) {
        mcp.digitalWrite(k, HIGH);
        delay(t);
        mcp.digitalWrite(k, LOW);
      }
      else if (k >= 16 && k <= 31) {
        mcp1.digitalWrite(k-16, HIGH);
        delay(t);
        mcp1.digitalWrite(k-16, LOW);
      }
      else if (k >= 32 && k <= 47)  {
        mcp2.digitalWrite(k-32, HIGH);
        delay(t);
        mcp2.digitalWrite(k-32, LOW);
      }
      else {
        mcp3.digitalWrite(k-48, HIGH);
        delay(t);
        mcp3.digitalWrite(k-48, LOW);
      }
    }
  }
}
