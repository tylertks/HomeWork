#SikkemaTPR7.py
#Tyler Sikkema
#June 27, 2016
#Abstract: Reading from a file to find costs for customers
#===========================================================
CD_PRICE = 16.5
DVD_PRICE = 21.75

#Main function
def Main():
    #Print the title line
    print('{}| {}| {}| {}'.format("Name".ljust(20),"Code".ljust(20),"Spindles".ljust(20),"Payment Due".ljust(20)))
    print('-----------------------------------------------------------------------------')
    #Boolean that allows us to exit the loop
    moreData = True
    #Keeps track of totals
    totalPayment = 0
    totalCDs=0
    totalDVDs=0
    #The file we are reading
    file = open('disks.txt','r')
    #Loop for reading and formatting data
    while(moreData==True):
        #Reads 3 lines of data
        data=ReadLine(file)
        if(data[0]!=''):
            #Processses and formats the data
            values=ShowData(data)
            #Update totals
            totalPayment+=values[0]
            totalCDs+=values[1]
            totalDVDs+=values[2]
        else:
            #At the end, print the totals
            print('People buying CDs: {}'.format(totalCDs))
            print('People buing DVDs: {}'.format(totalDVDs))
            print('Total Payment Due: {}'.format(totalPayment))
            print('end of file')
            moreData=False
#Read 3 lines from file
def ReadLine(file):
    name=file.readline()
    code=file.readline()
    number=file.readline()
    output = [name,code,number]
    #Return the data that was read, in a tuple
    return output
#Format and display the data
def ShowData(data):
    output = ""
    #Keeps track of data processed
    DVDs=0
    CDs=0
    totalPrice=0
    for x in range(0,3):
        #Display the data in a fixed-width table
        data[x] = data[x].strip()
        output+=data[x].ljust(20)
        output+="| "
    #Calculates the price of CDs
    if(data[1].lower()=="c"):
        output+='{:10.2f}'.format(int(data[2])*CD_PRICE)
        CDs+=1
        totalPrice=(int(data[2])*CD_PRICE
    #Calculates the price of DVDs
    elif(data[1].lower()=="d"):
        output+='{:10.2f}'.format(int(data[2])*DVD_PRICE)
        DVDs+=1
        totalPrice=(int(data[2])*DVD_PRICE)
    else:
        output+="ERROR"
    print(output)
    #Return totals for tracking
    returnValues=(totalPrice,CDs,DVDs)
    return returnValues


Main()

input("Press ENTER to continue...")
