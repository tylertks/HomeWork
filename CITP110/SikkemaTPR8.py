#SikkematPR8.py
#Tyler Sikkema
#July 11, 2016
#Abstract: Read, list, and sort names
#==============================================
def Main():
    myFile = open('names.txt','r')
    fileText=myFile.read()
    names = fileText.split('\n')
    for x in range(0,len(names)):
        nameChecker = names[x].strip()
        if(nameChecker==''):
            names.remove(names[x])
    print('\nNames from file\n---------------------')
    ShowNames(names)
    names.sort()
    print('\nSorted alphabetically\n-------------------')
    ShowNames(names)
    OutputNames(names)
    again = True
    while(again==True):
        SearchNames(names)
        answerAgain=True
        while(answerAgain==True):
            answer = input('Search Again(y/n)? ')
            if(answer.lower()=='y'):
                again = True
                answerAgain=False
            elif(answer.lower()=='n'):
                again = False
                answerAgain=False
            else:
                print('invalid input')
def ShowNames(names):
    for x in range(0,len(names)):
        print(names[x])

def OutputNames(names):
    outputFile = open('sorted names.txt','w')
    for x in range(0,len(names)):
        outputFile.write('{}\n'.format(names[x]))

def SearchNames(names):
    searchName = input('Enter Name to search for: ')
    nameList = searchName.split()
    try:
        reverseName = "{}, {}".format(nameList[1],nameList[0])
    except:
        reverseName=''
    if(searchName in names):
        print('Found {} in list.'.format(searchName))
    elif(reverseName!='' and reverseName in names):
        print('Found {} in list.'.format(searchName))
    else:
        print('Name \"{}\" not found in list.'.format(searchName))

Main()

input('Press ENTER to continue...')
