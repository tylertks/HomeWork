#=========================================================================
# SikkemaTHW3.py
# Tyler Sikkema
# Created June 4, 2016
# Last updated 6/8/2016
# Abstract: Used for calculating total pay
#=========================================================================

global HOURLY_PAY_RATE
global COMMISSION_RATE
global WITHHOLDING_RATE

HOURLY_PAY_RATE = 7.5
COMMISSION_RATE = 0.05
WITHHOLDING_RATE = 0.25

def Main():
    DisplayMessage()
    name = input('Enter employee name: ')
    sales = input('Enter sales amount: ')
    hours = input('Enter hours: ')
    hourlyPay = float(hours)*HOURLY_PAY_RATE
    commission=float(sales)*COMMISSION_RATE
    grossPay=hourlyPay+commission
    withholding=grossPay * WITHHOLDING_RATE
    netPay = grossPay - withholding
    DisplayResults(hourlyPay,commission,grossPay,withholding,netPay)
    
def DisplayMessage():
    print('This program calculates the salesperson\'s pay\n'\
          'Five values are dislpayed:\n'\
          'hourly pay, comission, gross pay, withholding, and net pay\n\n')
    
def DisplayResults(hourlyAmount,commissionAmount,grossAmount,withholdingAmount,netAmount):
    print('RESULTS:\n'\
          'Hourly Pay:\t\t{}\n'\
          'Commission:\t\t{}\n'\
          'Gross Pay:\t\t{}\n'\
          'Withholding Amount:\t{}\n'\
          'Net Pay:\t\t{}\n'.format(hourlyAmount,commissionAmount,grossAmount,withholdingAmount,netAmount))
    
Main()
input('Press ENTER to continue...')
    