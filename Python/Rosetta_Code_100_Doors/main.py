""" 100 Doors

- 100 doors in row
- initially closed
- make a 100 passes
- 1st time - visit every door - toggle state
- 2nd time - visit every 2nd door - toggle state
- 3rd time - visit every 3rd door - toggle state
- name the final state of each door
"""

door_state = [False] * 100

for n in range(1, 101):
    for j in range(n, 101, n):
        door_state[j-1] = not door_state[j-1]

    print("Door number {0} is {1}".format(n, "opened" if door_state[n-1] else "closed"))
