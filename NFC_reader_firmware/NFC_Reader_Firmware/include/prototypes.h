void setupSerial();
void setupNFCReader();
void wifiConnect();
void configureTime();
void printLocalTime();
bool sendPOSTRequest(String messageJson);
time_t getCurrentTimestamp();
uint parserNFCResults(bool success, uint8_t (&uid)[7], uint8_t uidLength);
void beep(int count, int duration);