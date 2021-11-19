for i in range(2, 5):
    for j in range(10, 10000):
        if((j / 1000) % 10) ** i + ((j / 100) % 10) ** i + ((j / 10) % 10) ** i + (j % 10) ** i == j:
            print(j)

