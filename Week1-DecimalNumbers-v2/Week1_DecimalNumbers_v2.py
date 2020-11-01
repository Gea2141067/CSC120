print("This program will convert any number in base 10 to base 8")
number = int(input("insert the number you want to conver:"))
counter = 1;
residue = number;
answer = 0;
while True:
    if (number - (8**counter))>0:
        counter =  counter + 1
    else :
        counter = counter - 1
        break
for i in range (0, counter+1):
    answer = answer +  ((residue // (8**(counter-i)))*(10**(counter-i)))
    residue = (number % (8**(counter-i)))
print ("the given number in base 8 is:")
print (answer)