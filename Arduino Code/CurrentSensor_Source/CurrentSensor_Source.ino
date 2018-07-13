
#include <Wire.h>

int CurrentSensorAddress = 0x0f; // I2c address for the current sensor

int Data0,Data1; 
word SensorData;

void setup() {
  // put your setup code here, to run once:
  Wire.begin();
  Serial.begin(9600);
  delay(100);

  Wire.beginTransmission(CurrentSensorAddress);
  Wire.write(0x1B); //CNTL1 = 0x80
  Wire.write(0x80); 
  Wire.endTransmission();

  Wire.beginTransmission(CurrentSensorAddress);
  Wire.write(0x5C); //CNTL4 = 0x00
  Wire.write(0x00); 
  Wire.endTransmission();
  
  Wire.beginTransmission(CurrentSensorAddress);
  Wire.write(0x5D); //CNTL4 = 0x00
  Wire.write(0x00); 
  Wire.endTransmission();

  Wire.beginTransmission(CurrentSensorAddress);
  Wire.write(0x1C); //CNTL2 = 0x08
  Wire.write(0x08); 
  Wire.endTransmission();

  Wire.beginTransmission(CurrentSensorAddress);
  Wire.write(0x1D); //CNTL3 = 0x40
  Wire.write(0x40); 
  Wire.endTransmission();
  
  

}

void loop() {
  // put your main code here, to run repeatedly:
  
  Wire.beginTransmission(CurrentSensorAddress);
  Wire.write(0x10); //first address to read
  Wire.endTransmission();

  Wire.requestFrom(CurrentSensorAddress,2);

   if(Wire.available()<=2) {  //  
        Data0 = Wire.read(); // Reads the data from the register 
        Data1 = Wire.read();    
      } 

  SensorData= word(Data1,Data0);

  Serial.println(SensorData,HEX); 
  //Serial.print("\n");

  //Serial.print("Data0= "); 
  //Serial.print(Data0,HEX); 
  //Serial.print("   Data1= "); 
  //Serial.println(Data1,HEX); 
  
  delay(300);
  

}
