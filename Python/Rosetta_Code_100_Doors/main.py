for n in range(1, 101):

    # Check if the square root of nth number 
    # has remainder when divided by 1.
    # If yes, the nth door will be closed.
    # If no, the nth door will be opened.
    if n**0.5 % 1 == 0:
        print(f"Door {n} is opened.")
    else:
        print(f"Door {n} is closed.")
