#SikkemaTPR5.py
#Tyler Sikkema
#June 20, 2016
#Abstract: Allows students to enter a name and homework scores, returns the average
#================================================================

def Main(studentCount=1):
    name=input('Enter Student Name: ')
    totalScore=0
    numScores=0
    firstScore=False
    getScores=True
    lowScore=0
    highScore=0
    students=studentCount
    while(firstScore==False):
        tempScore=float(input('Enter the first score: '))
        if(CheckNum(tempScore)== False):
            print('Invalid number, try again')
        else:
            firstScore=True
            numScores+=1
            totalScore+=tempScore
            lowScore=tempScore
            highScore=tempScore
    moreScores = int(input('How many additional scores?(0-3): '))
    if(moreScores > 0):
        for i in range(0,moreScores):
            scoreCheck=True
            while(scoreCheck==True):
                tempScore=float(input('Enter Score: '))
                if(CheckNum(tempScore)==False):
                    print('Invalid number, try again.')
                else:
                    scoreCheck=False
                    numScores+=1
                    totalScore+=tempScore
                    lowScore=GetLow(tempScore,lowScore)
                    highScore=GetHigh(tempScore,highScore)
    else:
        print('No additional Scores.')
    averageScore=(totalScore/numScores)
    print('{}\'s Scores:\n'\
    'Average Score: {}\n'\
    'High Score: {}\n'\
    'Low Score: {}'.format(name,format(averageScore,'.2f'),highScore,lowScore))
    another = input('Process another student(y/n)? ')
    if(another.lower()=='y'):
        Main(students+1)
    else:
        print('{} Students were processed'.format(students))

def GetHigh(num1,num2):
    if(num1>num2):
        return num1
    else:
        return num2

def GetLow(num1,num2):
    if(num1 < num2):
        return num1
    else:
        return num2

def CheckNum(num):
    if(num > 25 or num < 0):
        return False
    else:
        return True

Main()
