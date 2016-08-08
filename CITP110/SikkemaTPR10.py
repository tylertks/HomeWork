#SikkematPR10.py
#Tyler Sikkema
#August 8, 2016
#Abstract: Store Data for Workers
#==============================================
from person import *

def Main():
    employeeList=[]
    again = True
    while(again == True):
        name = input("Input Employee Name: ")
        ID = input('Input Employee ID: ')
        city = input('Input Employee City: ')
        validPay = False
        while(validPay == False):
            payType = input('Please Select Pay Type (V)olunteer, (H)ourly, or (S)alary: ')
            if(payType.lower()=='v'):
                validPay = True
                employeeList.append(Person(name,ID,city))
            elif(payType.lower()=='s'):
                validPay = True
                numValid = False
                while(numValid == False):
                    salary = input('Enter Employee\'s Salary: ')
                    try:
                        sal = float(salary)
                        numValid = True
                    except:
                        print('Not a Valid Number')
                employeeList.append(Salary(name,ID,city,sal))
            elif(payType.lower()=='h'):
                validPay = True
                numValid = False
                shiftValid = False
                while(numValid == False):
                    pay = input('Enter Employee\'s Hourly Rate: ')
                    try:
                        rate = float(pay)
                        numValid = True
                    except:
                        print('Not a Valid Number')
                while(shiftValid == False):
                    shiftNum = input('Enter Employee\'s Shift(1/2/3): ')
                    try:
                        shift = int(shiftNum)
                        shiftValid = True
                    except:
                        print('Not a Valid Shift Number')

                employeeList.append(Hourly(name,ID,city,rate,shift))
            if(isinstance(employeeList[-1],Person)):
                employeeList[-1].show_person()
                employeeList[-1].show_pay()
            else:
                print('Invalid Input')
            againValid = False
            while(againValid == False):
                goAgain = input('Input More Employees(y/n)? ')
                if(goAgain.lower()=='y'):
                    againValid = True
                elif(goAgain.lower()=='n'):
                    againValid = True
                    again = False
                    for person in employeeList:
                        person.show_person()
                        person.show_pay()
                else:
                    print('Improper input')

Main()

input('Press ENTER to continue...')
