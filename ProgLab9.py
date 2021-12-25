def init():
    global line
    global wordLength
    line = input("Enter line: ")
    wordLength = int(input("Enter word length: "))
def getWords(line):
    global words
    words = line.split()
    return words
def displayWords(words, length):
    i = 0
    while(i < len(words)):
        if(len(words[i]) == length):
            print(words[i])
        i += 1
init()
displayWords(getWords(line), wordLength)
