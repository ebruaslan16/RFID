#include <SPI.h>
#include <MFRC522.h>
 
#define SS_PIN 7
#define RST_PIN 9
MFRC522 mfrc522(SS_PIN, RST_PIN);   // MFRC522 örneği oluşturun.
 
void setup() 
{
  Serial.begin(9600);   // Seri iletişim başlat
  SPI.begin();      // SPI veri yolunu başlat
  mfrc522.PCD_Init();   // MFRC522'yi başlatın
  Serial.println("Kartınızı okuyucuya yaklaştırın...");
  Serial.println();

}
void loop() 
{
  // Yeni kartlar arayın
  if ( ! mfrc522.PICC_IsNewCardPresent()) 
  {
    return;
  }
  // Kartlardan birini seçin
  if ( ! mfrc522.PICC_ReadCardSerial()) 
  {
    return;
  }
  //UID'yi seri monitörde göster
  Serial.print("UID etiketi :");
  String content= "";
  byte letter;
  for (byte i = 0; i < mfrc522.uid.size; i++) 
  {
     Serial.print(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " ");
     Serial.print(mfrc522.uid.uidByte[i], HEX);
     content.concat(String(mfrc522.uid.uidByte[i] < 0x10 ? " 0" : " "));
     content.concat(String(mfrc522.uid.uidByte[i], HEX));
  }
  Serial.println();
  Serial.print("İleti : ");
  content.toUpperCase();
  if (content.substring(1) == "82 96 7E 21") //erişim vermek istediğiniz kartın/kartların UID'sini buradan değiştirin
  {
    Serial.println("Yetkili erişim");
    Serial.println();
    delay(1000);
  }
 
 else   {
    Serial.println("Erişim reddedildi");
    delay(1000);
  }
} 
