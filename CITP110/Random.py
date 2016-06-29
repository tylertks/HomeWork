#RandomNumberGuesser.py
#Tyler Sikkema
#May 23, 2016
######################################

import random

print('Welcome to the Random Number Guesser! Press Ctrl-C to exit at any time.')

def Rando():
	inp=input('\nGuess a number 1-100:\n')
	try:
		if(int(inp) >= 1 and int(inp) <= 100):
			rand=random.randint(1,100)
			if(int(inp)==rand):
				print('Great job! You guessed it!')
			else: 
				print('Wrong! You guessed {} and the number was {}'.format(inp,rand))
		else:
			print('Error! Please guess a number between 1 and 100')
	except:
		print('Not a number')
	input('\nPress ENTER to play again\n')
	Rando()
    
Rando()