# Find the factorial of 3
# 3 x 2 x 1
# Answer: 6


# using while loop

number = 20
answer = 1

while True:
    if number == 0:
        break

    answer *= number
    number -= 1

print("While Loop: {:,}".format(answer))

# using for loop

for i in range(number, 0, -1):
    answer *= i

print("For Loop: {:,}".format(answer))


# Using recursion

number = 20
def factorial(number):
    if number == 0:
        return 1
    else:
        return number * factorial(number - 1)

print("Recursion:", factorial(number))