line = input("Enter line: ")
wordLength = int(input("Enter word's length: "))
wordsArray = line.split(" ")
i = 0
while(i < len(wordsArray)):
    if(len(wordsArray[i]) == wordLength):
        print(wordsArray[i] + " ")
    i+=1
