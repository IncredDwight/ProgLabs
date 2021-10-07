x = float(input("Enter x: "))
y = float(input("Enter y: "))
if(abs(y) >= x ** 2 and abs(x) >= y ** 2):
    print("Point is inside plane")
else:
    print("Point is outside plane")
