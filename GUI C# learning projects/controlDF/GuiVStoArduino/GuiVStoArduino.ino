/*Programa para comunicar Arduino mediante el puerto serial
  ----------------------------------------------------------
  Editor: Daniel Galicia

  Finalidad: Controlar el encendido y apagado de un LED
*/
String inputString = "";
bool stringComplete = false;
int const outLed = 2;

void setup() {
  Serial.begin(9600);
  pinMode(outLed,OUTPUT);
  digitalWrite(outLed,LOW);
}

void loop() {
  //Revisar si la GUI en C# envio una cadena
  if(stringComplete)
  {
  inputString.trim();
  Serial.println(inputString);

  //Procesar la entrada
  if (inputString.equals("$On"))
  {
    digitalWrite(outLed, HIGH);
    }

  else if (inputString.equals("$Off"))
  {
    digitalWrite(outLed,LOW);
    }

    //Vaciar la cadena recibida
    inputString = "";
    stringComplete = false;
  }
}

//Esta funcion lee la cadena y secciona hasta que termine su entrada
void serialEvent()
{
  while (Serial.available())
  {
    char inChar = (char)Serial.read();
    if (inChar == '\n')
    {
      stringComplete = true;
      }
      else
      {
        inputString += inChar;
        }
    }
  }
