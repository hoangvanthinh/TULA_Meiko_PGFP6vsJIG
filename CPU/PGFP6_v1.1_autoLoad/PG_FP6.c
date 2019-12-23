#include "user.h"

void PG_FP6_Controller(void)
{
//  if(Status_CONN == HIGH)
//  {
//    
//  }
//  else
//  {
//    
//  }

    PetitRegisters[ADD_CONN].ActValue = Status_CONN;
    PetitRegisters[ADD_BUSY].ActValue = Status_BUSY;
    PetitRegisters[ADD_ERROR].ActValue = Status_ERROR;
    PetitRegisters[ADD_PASS].ActValue = Status_PASS;
    PetitRegisters[ADD_CTHT].ActValue = PD0;
    
    
  //------------------------------ COMMAND START ----------------------------//
  if(PetitRegisters[ADD_START].ActValue == 1)
  {
      if(Timer_Tick_Command_Start == 0)
          Bot_START = 1;
      else if(Timer_Tick_Command_Start >= 50)
      {
          Bot_START = 0;
          Timer_Tick_Command_Start = 0;
          PetitRegisters[ADD_START].ActValue = 0;
      }
  }
  //----------------------------- COMMAND CLR ------------------------------//
  if(PetitRegisters[ADD_CLR].ActValue == 1)
  {
      if(Timer_Tick_Command_CLR == 0)
          Bot_CANCEL_CLR = 1;
      else if(Timer_Tick_Command_CLR >= 50)
      {
          Bot_CANCEL_CLR = 0;
          Timer_Tick_Command_CLR = 0;
          PetitRegisters[ADD_CLR].ActValue = 0;
      } 
  }

  
}

