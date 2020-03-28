
ECHO If nanoff is not installed see https://github.com/nanoframework/nanoFirmwareFlasher
ECHO Change serial port if needed

nanoff --target ESP32_WROOM_32 --serialport COM3 --deploy --image "C:\NF.HardwareLib.Firmware\bootloader.bin" --address 0x1000 
nanoff --target ESP32_WROOM_32 --serialport COM3 --deploy --image "C:\NF.HardwareLib.Firmware\nanoCLR.bin" --address 0x10000 
nanoff --target ESP32_WROOM_32 --serialport COM3 --deploy --image "C:\NF.HardwareLib.Firmware\partitions_4mb.bin" --address 0x8000
  