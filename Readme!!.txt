1.Block of data
10 bytes: 
-RFID: 4bytes: Change each hex to char
-Door: 1byte: 1->4
-Day: 1byte: (1 bit is one day) bit 1 -> bit 7 from monday to sunday
-Time: 4bytes: hourFrom, minuteFrom, hourTo, minuteTo


2.To send special character in ascii Use 
//data to send via TCP or any stream/file
byte[] string_to_send = UTF8Encoding.UTF8.GetBytes("amé");

//when receiving, pass the array in this to get the string back
string received_string = UTF8Encoding.UTF8.GetString(message_to_send)