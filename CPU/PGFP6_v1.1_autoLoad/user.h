#include <stdio.h>
#include "NUC230_240.h"
#include "PetitModbus.h"
#include "Init.h"
#include "PGFP6.h"

#define PLL_CLOCK           72000000

#define HIGH 1
#define LOW 0

/*--------------- define IO -------------------------------*/
#define Status_CONN  PE14
#define Status_BUSY  PE13
#define Status_PASS  PB14
#define Status_ERROR PB13

#define Bot_CANCEL_CLR  PA11  // CLR = CANCEL
#define Bot_ENTER   PA10
#define Bot_NEXT    PA9
#define Bot_VRF     PB6
#define Bot_START   PB7

#define BUZZER  PE15

#define IN1 PD0
#define IN2 PD1
#define IN3 PD2
#define IN4 PD3

#define RL1 PC14
#define RL2 PC15
#define RL3 PC6
#define RL4 PC7
#define RL5 PD5
#define RL6 PD4

#define LED_R PB10
#define LED_G PB9
#define LED_B PB11

/*------------------- Address Modbus RTU ---------------------------*/
#define ADD_CONN  1
#define ADD_BUSY  2
#define ADD_PASS  3
#define ADD_ERROR 4
#define ADD_START 5
#define ADD_CLR 6
#define ADD_VRF 7
#define ADD_CTHT 8




extern volatile unsigned short Timer_Tick_Counter;
extern volatile unsigned short Timer_Tick_Command_Start, Timer_Tick_Command_CLR;


