
def Init():
    global a
    a = int(input("Enter a: "))
    global b
    b = (input("Enter b: "))
    global c
    c = int(input("Enter c: "))
    
def Gcd(num1, num2):
    while num1 != num2:
        if(num1 > num2):
            num1 -= num2
        else:
            num2 -= num1
    return num1

def Solution():
    global result
    result = Gcd(Gcd(a, b), c)
    
def Browse():
    print("Result: " + str(result))


Init()
Solution()
Browse()
