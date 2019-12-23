#include "user.h"




int32_t main()
{
  SYS_Init();
  InitPetitModbus(1);
  IO_Init();

  
  BUZZER = 0;
  while(1)
  {    
    ProcessPetitModbus();
    PG_FP6_Controller();
    Buzzer();
      
  }
}
