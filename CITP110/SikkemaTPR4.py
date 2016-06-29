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
        balance = float(input("Please enter your account Balance: "))
        transaction = input("Enter \'W\' for Withdrawal or \'D\' for Deposit: ")
        transactionAmount = float(input("Enter transaction amount: "))
        process=True        
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
        DisplayBalance(newBalance)
    else:
        print("You cannot withdraw that much.")
        DisplayBalance(balance)
def ProcessDeposit(balance,amount):
    newBalance = balance + amount
    DisplayBalance(newBalance)
def ProcessInvalidCode(balance):
    print("Invalid Transaction.\n")
    DisplayBalance(balance)
def DisplayBalance(balance):
    print("Your balance is {}".format(format(balance,'.2f')))
    
Main()
input("Press ENTER to continue...")
