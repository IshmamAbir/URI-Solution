number = int(input("Input your number :"))

import random

random_number= random.randint(1,100)

turns = 1
game_over= False

while not game_over:
    if number == random_number:
        print(f"you win ! You have done it in {turns} turns")
        game_over=True
    else:
        if number < random_number:
            print("Your guess is too low")
        else:
            print("Your guess is too high")

        number= int(input("Input again:"))
        turns+=1

