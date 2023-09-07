// To convert temperatures in degrees Fahrenheit to Celsius, first subtract 32,
// then multiply by five ninths (5 / 9).

int fahrenheit = 94;

decimal result = ((fahrenheit - 32) * 5) / 9m;

Console.WriteLine($"The temperature is {result} Celcius.");
