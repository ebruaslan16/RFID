#include <SPI.h>
#include <MFRC522.h>

#define RST_PIN         9
#define SS_1_PIN        10
#define SS_2_PIN        7
#define SS_3_PIN        4


// Doğru ID'ler
byte tagarray[][4] = {
  {0x82,0x96,0x7E,0x21},
  {0x82,0x56,0x6B,0x21},
  {0xF1,0x3D,0x11,0x22}
};


// Kilitlenme durumu:
int tagcount = 0;
bool access = false;

#define NR_OF_READERS   3 // 3 adet okuyucu tanımla

byte ssPins[] = {SS_1_PIN, SS_2_PIN, SS_3_PIN}; // Okuyucuların değişkenlerini tanımla

// Bir MFRC522 örneği oluşturun:
MFRC522 mfrc522[NR_OF_READERS];

void setup() {

  Serial.begin(9600);           // Haberleşmeyi tanımla
  while (!Serial);              

  SPI.begin();                  // SPI tanımla


  /* MFRC522 okuyucuları arıyorum */
  for (uint8_t reader = 0; reader < NR_OF_READERS; reader++) {
    mfrc522[reader].PCD_Init(ssPins[reader], RST_PIN);
    //Serial.print(F("Okuyucu "));
    //Serial.print(reader);
    //Serial.print(F(": "));
    mfrc522[reader].PCD_DumpVersionToSerial();
    //mfrc522[reader].PCD_SetAntennaGain(mfrc522[reader].RxGain_max);
  }
}


void loop() {

  for (uint8_t reader = 0; reader < NR_OF_READERS; reader++) {

    // Yeni kartlar arıyorum
    if (mfrc522[reader].PICC_IsNewCardPresent() && mfrc522[reader].PICC_ReadCardSerial()) {
     // Serial.print(F("Okuyucu "));
      //Serial.print(reader);

      
      // Kart IDlerini yazdır
      Serial.print(F(""));
      dump_byte_array(mfrc522[reader].uid.uidByte, mfrc522[reader].uid.size);

      for (int x = 0; x < sizeof(tagarray); x++)                  // tagarray'ın sırası
      {
        for (int i = 0; i < mfrc522[reader].uid.size; i++)        //tagarray sütunları
        {
          if ( mfrc522[reader].uid.uidByte[i] != tagarray[x][i])  //Arabellekteki UID'yi etiket dizisindeki UID ile karşılaştırma.
          {
            DenyingTag();
            break;
           
          }
          else
          {
            if (i == mfrc522[reader].uid.size - 1)                // Tüm UID'ye göz atıp taramadığımızı test edin.
            {
              AllowTag();
            }
            else
            {
              continue;                                           // Hâlâ son hücreye/sütunlara ulaşamadık: test etmeye devam edin!
            }
          }
        }
        if(access) break;
      }
     

     if (access)
     {
        OpenDoor();
     }
          
     else
     {
       UnknownTag();
     }

      mfrc522[reader].PICC_HaltA();
    // Stop encryption on PCD
     mfrc522[reader].PCD_StopCrypto1();
       
    }        
   } 
  }


/**
   Bir bayt dizisini onaltılık değerler olarak Seri'ye boşaltmak için yardımcı yordam.
*/

void dump_byte_array(byte * buffer, byte bufferSize) {
  for (byte i = 0; i < bufferSize; i++) {
    Serial.print(buffer[i] < 0x10 ? " 0" : " ");
    Serial.print(buffer[i], HEX);
  }
}

void printTagcount() {
  //Serial.print("Tag n°");
 // Serial.println(tagcount);
 
}

void DenyingTag()
{
  tagcount = tagcount;
  access = false;
}

void AllowTag()
{
  tagcount = tagcount + 1;
  access = true;
}

void Initialize()
{
  tagcount = 0;
  access = false;
}
void OpenDoor()
{
 // Serial.println("Doğru ID");
  Initialize();
}
void MoreTagsNeeded()
{
  printTagcount();
  //Serial.println("Sistem kart bekliyor");
  access = false;
}
void UnknownTag()
{
  //Serial.println("Yanlış ID");
  printTagcount();
}
