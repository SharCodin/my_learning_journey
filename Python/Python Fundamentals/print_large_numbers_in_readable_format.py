"""
In Python, you can use the `format()` function to print large numbers in a human-readable format with commas for better readability. Here's how you can do it:

```python
number = 2432902008176640000
formatted_number = "{:,}".format(number)

print(formatted_number)
```

The `format()` function formats the number using the specified format specification. The `:,` in the format string tells Python to use commas as a thousands separator. When you run this code, it will print the number in a human-readable format:

```
2,432,902,008,176,640,000
```

This makes it easier to read large numbers at a glance.
"""

number = 2432902008176640000
formatted_number = "{:,}".format(number)

print(formatted_number)