
#include <arduino.h>

#include <Wire.h>
#include <MCP342x.h>
#include <MCP_DAC.h>

#define VERSION "TubeTester version 1.00"

#define LED 7
#define CS1 10
#define CS2 9

#define DAC_SHDN 8

MCP4922 MCP_DAC1;  // HW SPI
MCP4922 MCP_DAC2;  // HW SPI

MCP342x MCP_ADC1 = MCP342x(0x68);
MCP342x MCP_ADC2 = MCP342x(0x6C);

int index = 0;
char cmd[16];

void setup()
{
  uint8_t address[] = {0x68, 0x69, 0x6A, 0x6B, 0x6C, 0x6D, 0x6E, 0x6F};
  int i;
  pinMode(LED, OUTPUT); //LED

  pinMode(DAC_SHDN, INPUT);

  digitalWrite(LED, LOW);
  
  Serial.begin(115200);

  MCP_DAC1.begin(CS1);
  MCP_DAC2.begin(CS2);

  Wire.begin(); 

  delay(100);

  // MCP3424 Reset devices
  MCP342x::generalCallReset();
  delay(1); // MC342x needs 300us to settle

  for(int i = 0; i < 8; i++)
  {
    // Check device present
    Wire.requestFrom(address[i], (uint8_t)1);
    if (Wire.available()) {
      Serial.print("Device found at address ");
      Serial.println(address[i], HEX);
    }
  }
  
  // Check device present
  Wire.requestFrom((uint8_t)0x68, (uint8_t)1);
  if (!Wire.available()) {
    Serial.print("No device found at address ");
    Serial.println(0x68, HEX);
    while (1)
      ;
  }  
  Wire.requestFrom((uint8_t)0x6C, (uint8_t)1);
  if (!Wire.available()) {
    Serial.print("No device found at address ");
    Serial.println(0x6C, HEX);
    while (1)
      ;
  }  
  Serial.println("\nReady");
  digitalWrite(LED, HIGH);
}

//プレート電圧
double getPV()
{
  long ad = 0;
  const double Factor = (2.048 / 131072);
  double ret = 0;

  MCP342x::Config status;
  // Initiate a conversion; convertAndRead() will wait until it can be read
  //チャネル, モード, 分解能, ゲイン, タイムアウト, 計測値へのポインタ, ステータス(Config)構造体へのポインタ
  uint8_t err = MCP_ADC1.convertAndRead(MCP342x::channel1, MCP342x::oneShot,
           MCP342x::resolution18, MCP342x::gain1,
           1000000, ad, status);
  if (err) {
    Serial.print("ERR ");
    Serial.println(err);
    return NAN;
  }
  else {
    //Serial.print("Value: ");
    //Serial.println(ad);
  }

  //VB=VB-AD*(27k+3k)/3k
  ret = (double)ad * Factor * (27000 + 3000) / 3000;

  return ret;
}

//スクリーングリッド電圧
double getG2V()
{
  long ad = 0;
  const double Factor = (2.048 / 131072);
  double ret = 0;

  MCP342x::Config status;
  // Initiate a conversion; convertAndRead() will wait until it can be read
  //チャネル, モード, 分解能, ゲイン, タイムアウト, 計測値へのポインタ, ステータス(Config)構造体へのポインタ
  uint8_t err = MCP_ADC1.convertAndRead(MCP342x::channel2, MCP342x::oneShot,
           MCP342x::resolution18, MCP342x::gain1,
           1000000, ad, status);
  if (err) {
    Serial.print("ERR ");
    Serial.println(err);
    return NAN;
  }
  else {
    //Serial.print("Value: ");
    //Serial.println(ad);
  }

  //VSG=VSG-AD*(27k+3k)/3k
  ret = (double)ad * Factor * (27000 + 3000) / 3000;

  return ret;
}

//グリッド電圧
double getG1V()
{
  long ad = 0;
  const double Factor = (2.048 / 131072);
  double ret = 0;

  MCP342x::Config status;
  // Initiate a conversion; convertAndRead() will wait until it can be read
  //チャネル, モード, 分解能, ゲイン, タイムアウト, 計測値へのポインタ, ステータス(Config)構造体へのポインタ
  uint8_t err = MCP_ADC1.convertAndRead(MCP342x::channel3, MCP342x::oneShot,
           MCP342x::resolution18, MCP342x::gain1,
           1000000, ad, status);
  if (err) {
    Serial.print("ERR ");
    Serial.println(err);
    return NAN;
  }
  else {
    //Serial.print("Value: ");
    //Serial.println(ad);
  }

  //VG=VG-AD*(-1)*12k/12k
  ret = (double)ad * Factor * (-1.0) * 12000 / 12000;

  return ret;
}

//プレート電流
double getPI()
{
  long ad = 0;
  const double Factor = (2.048 / 131072);
  double ret = 0;

  MCP342x::Config status;
  // Initiate a conversion; convertAndRead() will wait until it can be read
  //チャネル, モード, 分解能, ゲイン, タイムアウト, 計測値へのポインタ, ステータス(Config)構造体へのポインタ
  uint8_t err = MCP_ADC1.convertAndRead(MCP342x::channel4, MCP342x::oneShot,
           MCP342x::resolution18, MCP342x::gain1,
           1000000, ad, status);
  if (err) {
    Serial.print("ERR ");
    Serial.println(err);
    return NAN;
  }
  else {
    //Serial.print("Value: ");
    //Serial.println(ad);
  }

  //IB=IB-AD/1/(1+49400/470)
  ret = (double)ad * Factor / 1.0 / (1.0 + 49400.0 / 470.0) * 1000.0; //mA

  return ret;
}

//ヒータ電圧
double getHV()
{
  long ad = 0;
  const double Factor = (2.048 / 131072);
  double ret = 0;

  MCP342x::Config status;
  // Initiate a conversion; convertAndRead() will wait until it can be read
  //チャネル, モード, 分解能, ゲイン, タイムアウト, 計測値へのポインタ, ステータス(Config)構造体へのポインタ
  uint8_t err = MCP_ADC2.convertAndRead(MCP342x::channel2, MCP342x::oneShot,
           MCP342x::resolution18, MCP342x::gain1,
           1000000, ad, status);
  if (err) {
    Serial.print("ERR ");
    Serial.println(err);
    return NAN;
  }
  else {
    //Serial.print("Value: ");
    //Serial.println((double)ad * Factor);
  }

  //VA=VA-AD*(12k+2k)/2k
  ret = (double)ad * Factor * (12000.0 + 2000.0) / 2000.0;

  return ret;
}

//ヒータ電流
double getHI()
{
  long ad = 0;
  const double Factor = (2.048 / 131072);
  double ret = 0;

  MCP342x::Config status;
  // Initiate a conversion; convertAndRead() will wait until it can be read
  //チャネル, モード, 分解能, ゲイン, タイムアウト, 計測値へのポインタ, ステータス(Config)構造体へのポインタ
  uint8_t err = MCP_ADC2.convertAndRead(MCP342x::channel1, MCP342x::oneShot,
           MCP342x::resolution18, MCP342x::gain1,
           1000000, ad, status);
  if (err) {
    Serial.print("ERR ");
    Serial.println(err);
    return NAN;
  }
  else {
    //Serial.print("Value: ");
    //Serial.println((double)ad * Factor);
  }

  //IA=IA-AD/0.01/10000*100
  ret = (double)ad * Factor / 0.01 / 10000.0 * 100.0 * 1000.0; //mA

  return ret;
}

void setPV(double value)
{
  uint16_t DA;

  //Vref-B=VB*3k/(12k+3k)
  DA = (uint16_t)(value * 3000.0 / (12000.0 + 3000.0) / 4.096 * 4095.0);
  if(DA > 4095) DA = 4095;
  //Serial.println(value);
  //Serial.println(DA);
  MCP_DAC1.analogWrite(DA, 0);
}

void setG2V(double value)
{
  uint16_t DA;

  //Vref-B=VB*3k/(12k+3k)
  DA = (unsigned short)(value * 3000.0 / (12000.0 + 3000.0) / 4.096 * 4095.0);
  if(DA > 4095) DA = 4095;
  //Serial.println(value);
  //Serial.println(DA);
  MCP_DAC1.analogWrite(DA, 1);
}

void setG1V(double value)
{
  unsigned short DA1, DA2;

  //Vref-G=VG*(-1)*12k/3k
  if(value < 0)
  {
    DA1 = (unsigned short)(value * (-1.0) * 12000.0 / 3000.0 / 4.096 * 4095.0);
    DA2 = 0;
  }
  else
  {
    DA1 = 0;
    DA2 = (unsigned short)(value * 12000.0 / 3000.0 / 4.096 * 4095.0);
  }
  if(DA1 > 4095) DA1 = 4095;
  if(DA2 > 4095) DA2 = 4095;
  //Serial.println(value);
  //Serial.println(DA1);
  //Serial.println(DA2);
  MCP_DAC2.analogWrite(DA1, 0);
  MCP_DAC2.analogWrite(DA2, 1);
}

void ProcessCommand()
{
  double value;
  switch(cmd[0])
  {
    case 'g':
    case 'G':
      //get
      switch(cmd[1])
      {
        case '1':
          //VB
          value = getPV();
          break;
        case '2':
          //VSG
          value = getG2V();
          break;
        case '3':
          //VG
          value = getG1V();
          break;
        case '4':
          //IB
          value = getPI();
          break;
        case '5':
          //IA
          value = getHV();
          break;
        case '6':
          //VA
          value = getHI();
          break;
        default:
          Serial.println("ERR");
          return;
      }
      if(isnan(value)) break;
      //Serial.Print(cmd[1]);
      //Serial.Print(":");
      Serial.println(value, 3);
      break;
    case 's':
    case 'S':
      //set
      value = atof(&cmd[2]);
      switch(cmd[1])
      {
        case '1':
          //PV
          setPV(value);
          break;
        case '2':
          //G2V
          setG2V(value);
          break;
        case '3':
          //G1V
          setG1V(value);
          break;
        default:
          Serial.println("ERR");
          return;
      }
      Serial.println("OK");
      break;
    case 'v':
    case 'V':
      Serial.println(VERSION);
      break;
    default:
      Serial.println("ERR");
      break;
  }
}



void loop()
{
  char c;

  if(Serial.available() > 0)
  {
    c = Serial.read();

    if(index == 0 && (c == '\r' || c == '\n')) return;
    
    if(c == '\r' || c == '\n')
    {
      cmd[index] = '\0';
      ProcessCommand();
      index = 0;
      cmd[0] = '\0';
    }
    else
    {
      cmd[index++] = c;
      if(index > 15)
      {
        Serial.println("ERR");
        index = 0;
        cmd[0] = '\0';
      }
    }
  }
}
