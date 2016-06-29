#SikkemaTPR6.py
#Tyler Sikkema
#June 29, 2016
#Abstract: Rock, Paper, Scissors
#================================================================
import random

def Main():
    again = True
    wins = 0
    losses = 0
    draws = 0
    print('Welcome to Rock, Paper, Scissors')
    while(again == True):
        playerChoice = PlayerInput()
        if(playerChoice != 4):
            computerChoice = ComputerInput()
            result = GetWinner(playerChoice,computerChoice)
            if(result == 'win'):
                wins+=1
            elif(result == 'lose'):
                losses+=1
            elif(result == 'draw'):
                draws+=1
            else:
                print('Invalid Result')
            againInput = True
            while(againInput==True):
                playAgain = input('Play Again?(y/n): ')
                if(playAgain.lower() == 'y'):
                    again = True
                    againInput = False
                elif(playAgain.lower() == 'n'):
                    again = False
                    againInput = False
                else:
                    print('invalid input')
        else:
            print('Exiting Game')
            again = False
    print('Results:\n'\
          'Win: {}\n'\
          'Lose: {}\n'\
          'Draw: {}\n'.format(wins,losses,draws))
    
def PlayerInput():
    validInput = False
    while(validInput == False):
        playerChoice = input('Choose Rock(1), Paper(2), Scissors(3), or Quit(4): ')
        try:
            playerChoice = int(playerChoice)
            if(playerChoice > 0 and playerChoice < 5):
                if(playerChoice ==1):
                    print('You choose ROCK')
                elif(playerChoice == 2):
                    print('You choose PAPER')
                elif(playerChoice == 3):
                    print('You choose SCISSORS')
                validInput=True
                return playerChoice
            else:
                print('Invalid Input')
        except:
            print('Invalid Input')
        
    
def ComputerInput():
    computerChoice = random.randint(1,3)
    if(computerChoice == 1):
        print('Computer chooses ROCK')
    elif(computerChoice == 2):
        print('Computer chooses PAPER')
    elif(computerChoice == 3):
        print('Computer chooses SCISSORS')
    return computerChoice
    
def GetWinner(player,computer):
    processResults = True
    playerChoice=''
    computerChoice=''
    if(player == 1):
        playerChoice = 'ROCK'
    elif(player == 2):
        playerChoice = 'PAPER'
    elif(player == 3):
        playerChoice = 'SCISSORS'
    else:
        print('Player Input Error')
        processResults = False
    
    if(computer == 1):
        computerChoice = 'ROCK'
    elif(computer == 2):
        computerChoice = 'PAPER'
    elif(computer == 3):
        computerChoice = 'SCISSORS'
    else:
        print('Computer Input Error')
        processResults = False
    
    if(processResults == True):
        if(player == 1):
            if(computer == 1):
                result = 'draw'
            elif(computer == 2):
                result = 'lose'
            elif(computer == 3):
                result = 'win'
        elif(player == 2):
            if(computer == 1):
                result = 'win'
            elif(computer == 2):
                result = 'draw'
            elif(computer == 3):
                result = 'lose'
        elif(player == 3):
            if(computer == 1):
                result = 'lose'
            elif(computer == 2):
                result = 'win'
            elif(computer == 3):
                result = 'draw'
        if(result == 'win'):
            print('Your {} beats Computer\'s {}. You win!'.format(playerChoice,computerChoice))
        elif(result == 'lose'):
            print('Computer\'s {} beats your {}. You Lose!'.format(computerChoice,playerChoice))
        elif(result == 'draw'):
            print('You both chose {}. It\'s a Tie!'.format(playerChoice))
        return result

Main()

input('Press ENTER to continue...')