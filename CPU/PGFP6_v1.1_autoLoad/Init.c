#include "user.h"

void SYS_Init(void)
{
    SYS_UnlockReg();

    /* Init System, peripheral clock and multi-function I/O */
    /* Enable Internal RC 22.1184MHz clock */
    CLK_EnableXtalRC(CLK_PWRCON_OSC22M_EN_Msk);

    /* Waiting for Internal RC clock ready */
    CLK_WaitClockReady(CLK_CLKSTATUS_OSC22M_STB_Msk);

    /* Switch HCLK clock source to Internal RC and HCLK source divide 1 */
    CLK_SetHCLK(CLK_CLKSEL0_HCLK_S_HIRC, CLK_CLKDIV_HCLK(1));

    /* Enable external XTAL 12MHz clock */
    CLK_EnableXtalRC(CLK_PWRCON_XTL12M_EN_Msk);

    /* Waiting for clock ready */
    CLK_WaitClockReady(CLK_CLKSTATUS_XTL12M_STB_Msk);

    /* Set core clock as PLL_CLOCK from PLL */
    CLK_SetCoreClock(PLL_CLOCK);
    
    /* Enable UART module clock */
    CLK_EnableModuleClock(UART0_MODULE);    
    
    /* Select UART module clock source */
    CLK_SetModuleClock(UART0_MODULE, CLK_CLKSEL1_UART_S_HXT, CLK_CLKDIV_UART(1));

    /* Enable Timer1 module clock */
    CLK_EnableModuleClock(TMR0_MODULE);    

    /* Select Timer1 module clock source */
    CLK_SetModuleClock(TMR0_MODULE, CLK_CLKSEL1_TMR0_S_HCLK, NULL);

    /*---------------------------------------------------------------------------------------------------------*/
    /* Init I/O Multi-function                                                                                 */
    /*---------------------------------------------------------------------------------------------------------*/
    /* Set GPB multi-function pins for UART0 RXD and TXD */
    SYS->GPB_MFP &= ~(SYS_GPB_MFP_PB0_Msk | SYS_GPB_MFP_PB1_Msk);
    SYS->GPB_MFP |= SYS_GPB_MFP_PB0_UART0_RXD | SYS_GPB_MFP_PB1_UART0_TXD;


    /* Lock protected registers */
    SYS_LockReg();
}

void UART0_Init(void)
{
    /*---------------------------------------------------------------------------------------------------------*/
    /* Init UART                                                                                               */
    /*---------------------------------------------------------------------------------------------------------*/
    /* Reset UART0 */
    SYS_ResetModule(UART0_RST);

    /* Configure UART0 and set UART0 Baudrate */
    UART_Open(UART0, 19200);
      UART_ENABLE_INT(UART0, UART_IER_RDA_IEN_Msk);
    NVIC_EnableIRQ(UART02_IRQn);	
}

void TIMER0_Init(void)
{
    TIMER_Open(TIMER0, TIMER_PERIODIC_MODE, 1000);
    TIMER_EnableInt(TIMER0);
    NVIC_EnableIRQ(TMR0_IRQn);
    TIMER_Start(TIMER0);
}
void IO_Init(void)
{ 
    // --------------------CTHT ---------------------------
    GPIO_SetMode(PD, BIT0 | BIT1, GPIO_PMD_INPUT);

    //----------------- PG-FP6-CONTROLLER ------------------------//
    GPIO_SetMode(PB, BIT13 | BIT14, GPIO_PMD_INPUT);
    GPIO_SetMode(PE, BIT13 | BIT14, GPIO_PMD_INPUT);
  
    GPIO_SetMode(PA, BIT9 | BIT10 | BIT11, GPIO_PMD_OUTPUT);
    GPIO_SetMode(PB, BIT6 | BIT7, GPIO_PMD_OUTPUT);
    
  
    //----------------- BUZZER -----------------------------------//
    GPIO_SetMode(PE, BIT15, GPIO_PMD_OUTPUT);
    //----------------- IO ---------------------------------------//
    GPIO_SetMode(PD, BIT0 | BIT1 | BIT2 | BIT3, GPIO_PMD_INPUT);
    GPIO_SetMode(PC, BIT6 | BIT7 | BIT14 | BIT15, GPIO_PMD_OUTPUT);
    GPIO_SetMode(PD, BIT4 | BIT5 , GPIO_PMD_OUTPUT);
    //----------------- RGB --------------------------------------//
    GPIO_SetMode(PB, BIT9 | BIT10 | BIT11 , GPIO_PMD_OUTPUT);
  
    //==============================================================
    RL1 = RL2 = RL3 = RL4 = RL5 = RL6 = 0;
    Bot_START = 0;
    Bot_ENTER = 0;
    Bot_CANCEL_CLR = 0;
    Bot_NEXT = 0;
    Bot_VRF = 0;
  
}
void Buzzer(void)
{
    if(Bot_CANCEL_CLR || Bot_ENTER || Bot_NEXT || Bot_START || Bot_VRF)
        BUZZER = 1;
    else
        BUZZER = 0;
}
