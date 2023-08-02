# Python Fundamentals

Here is an explanation of shallow copy and deep copy in Python with examples:

Shallow copy:
- Creates a new object and copies the references from the original object. So the two objects will share the same nested objects.
- To do a shallow copy, you can use the copy() method or just assign one variable to another.

```python
import copy

original = [1, 2, [3, 4]]

# Shallow copy 
copy1 = original.copy()  

copy2 = original
```

Here copy1 and copy2 will be separate objects from original but they will share the same nested list [3, 4]. So if we modify the nested list in any of the copies, it will be reflected in all of them:

```python 
copy1[2].append(5)
print(copy1) # [1, 2, [3, 4, 5]]
print(copy2) # [1, 2, [3, 4, 5]] 
print(original) # [1, 2, [3, 4, 5]]
```

Deep copy:
- Creates a new object and recursively copies the nested objects present. So the copy will not share any objects with the original.
- To do a deep copy, use the deepcopy() method from the copy module.

```python
import copy

original = [1, 2, [3, 4]]

# Deep copy
copy3 = copy.deepcopy(original)

copy3[2].append(5)
print(copy3) # [1, 2, [3, 4, 5]]
print(original) # [1, 2, [3, 4]] 
```

Here copy3 will be a fully independent object with its own nested objects. So when we modify copy3, it doesn't affect original.