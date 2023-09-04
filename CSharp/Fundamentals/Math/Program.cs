int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;
decimal decimalDivision = 7.0m / 5;

Console.WriteLine(sum);
Console.WriteLine(difference);
Console.WriteLine(product);
Console.WriteLine(quotient);
Console.WriteLine(decimalDivision);

/* OUTPUT 

12
2
35
1

*/


// Type cast
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);