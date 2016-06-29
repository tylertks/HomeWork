#SikkemaTPR4.py
#Tyler Sikkema
#June 15, 2016
#Abstract: Program that can process bank transactions
#================================================================
def Main():
    loop = True
    
    while(loop==True):
        name = input("Please enter your name: ")
        account = input("Please enter your account ID: ")
        transaction = input("Enter \'W\' for Withdrawal or \'D\' for Deposit: ")
        transactionAmount = float(input("Enter transaction amount: "))
        balance = 0
        process=True        
        if(name.lower() == 'sally' and account == '10'):
            balance = 10.0
        elif(name.lower() == 'bill' and account == '23'):
            balance = 10.0
        elif(name.lower() == 'linda' and account == '42'):
            balance = 10.50
        elif(name.lower() == 'tom' and account == '31'):
            balance = 25.72
        elif(name.lower() == 'rich' and account == '75'):
            balance = 1234.56
        elif(name.lower() == 'chris' and account == '40'):
            balance = 10.0
        else:
            print("Invalid name and/or account ID")
            process=False
        
        if(process == True):    
            if(transaction.lower() == 'w'):
                ProcessWithdrawal(balance,transactionAmount)
            elif(transaction.lower() == 'd'):
                ProcessDeposit(balance,transactionAmount)
            else:
                ProcessInvalidCode(balance)
        else:
            print('No transaction processed')
        again = input("Process another transaction(y/n)?").lower()
        if(again == 'y'):
            loop = True
        else:
            loop = False
        
def ProcessWithdrawal(balance,amount):
    if(balance >= amount):
        newBalance = balance - amount
        print("Your new balance is ${}".format(format(newBalance,'.2f')))
    else:
        print("You cannot withdraw that much. Your balance is ${}".format(format(balance,'.2f')))
def ProcessDeposit(balance,amount):
    newBalance = balance + amount
    print("Your new balance is ${}".format(format(newBalance,'.2f')))
def ProcessInvalidCode(balance):
    print("Invalid Transaction.\n"\
          "Your balance is {}".format(format(balance,'.2f')))
    
Main()
input("Press ENTER to continue...")
