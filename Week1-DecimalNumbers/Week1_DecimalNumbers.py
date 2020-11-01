
print("This program will convert any number in base 10 to base 8")
number = int(input("insert the number you want to conver:"))
answer = ""
totalanswer = 0;
quotient = number
counter = 0;
while True:
    answer = answer + str(quotient%8)
    quotient = quotient // 8
    counter = counter +1
    if(quotient <1):
        break
for i in range (0, counter):
    totalanswer = totalanswer + int(answer[i])*(10**i)
print("the given number in base 8 is:  " + str(totalanswer))
