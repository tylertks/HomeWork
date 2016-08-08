#Person Script
#Contains Classes for Person, Salary, and Hourly

class Person:
    def __init__(self,name,id,city):
        self.Name = name
        self.ID = id
        self.City = city

    def show_person(self):
        print('\nEmployee Info\n--------------------\n'\
        'Name:\t{}\n'\
        'ID:\t{}\n'\
        'City:\t{}'.format(self.Name,self.ID,self.City))
    def show_pay(self):
        print('{} is a volunteer'.format(self.Name))

class Salary(Person):
    def __init__(self,name,id,city,salary):
        Person.__init__(self,name,id,city)
        self.Salary = salary
    def show_pay(self):
        print('Salary:\t${}'.format(format(self.Salary,',.2f')))

class Hourly(Person):
    def __init__(self,name,id,city,rate,shift):
        Person.__init__(self,name,id,city)
        self.Rate = rate
        self.Shift = shift
    def show_pay(self):
        bonus = 1
        if(self.Shift == 1):
            bonus=1
        elif(self.Shift == 2):
            bonus=1.05
        elif(self.Shift == 3):
            bonus=1.1
        pay = self.Rate * bonus
        print('Pay: ${} per hour'.format(format(pay,',.2f')))
