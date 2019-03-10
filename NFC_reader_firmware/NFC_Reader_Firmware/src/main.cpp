#include <Arduino.h>

#include <Wire.h>
#include <SPI.h>
#include <Adafruit_PN532.h>

#define DEBUG

// SPI Pins
#define PN532_SCK  (18)
#define PN532_MOSI (23)
#define PN532_SS   (5)
#define PN532_MISO (19)

// Speaker pin to notify about succesfull scan
#define SPEAKER     (25)

// NFC reader object
Adafruit_PN532 nfc(PN532_SCK, PN532_MISO, PN532_MOSI, PN532_SS);


// Function prototypes
void setupSerial();
void setupNFCReader();
void beep(int count, int duration);

void setup(void) {
  // Setup pins
  pinMode(SPEAKER, OUTPUT);
  
  setupSerial();
  setupNFCReader();

  // Nofify about finished setup
  beep(2, 100);
}

void loop(void) {
  boolean success;
  uint8_t uid[] = { 0, 0, 0, 0, 0, 0, 0 };	// Buffer to store the returned UID
  uint8_t uidLength;				// Length of the UID (4 or 7 bytes depending on ISO14443A card type)
  
  // Wait for an ISO14443A type cards
  // 'uid' will be populated with the UID, and uidLength will indicate
  // if the uid is 4 bytes (Mifare Classic) or 7 bytes (Mifare Ultralight)
  success = nfc.readPassiveTargetID(PN532_MIFARE_ISO14443A, &uid[0], &uidLength);
  
  if (success) {
    #ifdef DEBUG
    Serial.print("UID Length: ");Serial.print(uidLength, DEC);Serial.println(" bytes");
    Serial.print("UID Value: ");
    for (uint8_t i=0; i < uidLength; i++) 
    {
      Serial.print(" 0x");Serial.print(uid[i], HEX); 
    }
    Serial.println("");
    #endif
	// Wait 0.5 second before continuing
  beep(1,50);
  delay(400);
  }
  else
  {
    // PN532 probably timed out waiting for a card
    Serial.println("Timed out waiting for a card");
    beep(3,250);
  }
}


void setupNFCReader()
{
  // Setup NFC module
  nfc.begin();

  // Get info
  uint32_t versiondata = nfc.getFirmwareVersion();
  if (! versiondata) {
    Serial.print("Didn't find PN53x board");
    while (1); // halt
  }
  
  // Got ok data, print it out!
  #ifdef DEBUG
  Serial.print("Found chip PN5"); Serial.println((versiondata>>24) & 0xFF, HEX); 
  Serial.print("Firmware ver. "); Serial.print((versiondata>>16) & 0xFF, DEC); 
  Serial.print('.'); Serial.println((versiondata>>8) & 0xFF, DEC);
  #endif

  // Set the max number of retry attempts to read from a card
  // This prevents us from waiting forever for a card, which is
  // the default behaviour of the PN532.
  nfc.setPassiveActivationRetries(0xFF);
  
  // configure board to read RFID cards
  nfc.SAMConfig();
  
  Serial.println("Waiting for an RFID card");
}


void setupSerial()
{
  Serial.begin(115200);
  Serial.println("Startup!");
}


void beep(int count, int duration)
{
  for(int i = 0; i < count; i++)
  {
    digitalWrite(SPEAKER, HIGH);
    delay(duration);
    digitalWrite(SPEAKER, LOW);
    if (i != count -1) // Last beep must not have pause
    {
      delay(duration);
    }
    
  }
  
}
