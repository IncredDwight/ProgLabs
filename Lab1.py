fullNumber = float(input("Enter number: "))
integerPart = int(fullNumber) / 1000
fractionalPart = (fullNumber * 1000) % 1000
print(integerPart + fractionalPart)
