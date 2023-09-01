string firstName = "John";
Console.WriteLine($"Hello {firstName}");

string lastName = "Wick";
Console.WriteLine($"{firstName} {lastName}");

// Use verbatim literals and string interpolation together
Console.WriteLine($@"C:\Output\{firstName}");


// Challenge
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

/* Output
View English output:
  c:\Exercise\ACME\data.txt

Посмотреть русский вывод:
  c:\Exercise\ACME\ru-RU\data.txt
*/

Console.WriteLine("View English output:\n\t" + $@"c:\Exercise\{projectName}\data.txt");
Console.WriteLine($"\n{russianMessage}\n\t" + $@"c:\Exercise\{projectName}\ru-RU\data.txt");