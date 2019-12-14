birthdays = {'Luke': 'Apr 1', 'Jacob': 'Dec 12', 'Janelle': 'Mar 4'}

while True:
    print('Enter a first name: (Leave blank to shut down)')
    Firstname = input()
    if Firstname == '':
        break

    if Firstname in birthdays:
        print(birthdays[Firstname] + ' is the birthday of ' + Firstname)
    else:
        print('Error! No Birthday on file for ' + Firstname)
        print('Would you please enter their birthday?')
        bday = input()
        birthdays[Firstname] = bday
        print('Birthday spreadsheet updated.')
