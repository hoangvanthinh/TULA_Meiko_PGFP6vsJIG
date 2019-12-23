#include "user.h"

void TMR0_IRQHandler(void)
{
    TIMER_ClearIntFlag(TIMER0);

    PetitModBus_TimerValues();

    Timer_Tick_Counter++;
    //-------------------------------- TIMER SECCOND
    if(Timer_Tick_Counter >= 1000)
    {
      LED_B = ~LED_B;
      //BUZZER = ~BUZZER;
      Timer_Tick_Counter = 0;
    }
    //-------------------------------- BOT START 
    if(Bot_START == 1)
    {
        Timer_Tick_Command_Start ++;
    }
    //------------------------------- BOT CLR 
    if(Bot_CANCEL_CLR == 1)
    {
        Timer_Tick_Command_CLR++;
    }
    
}

void UART02_IRQHandler(void)
{
    if(UART_IS_RX_READY(UART0)) 
		{			
				ReceiveInterrupt(UART0->RBR);
    }
  
}
