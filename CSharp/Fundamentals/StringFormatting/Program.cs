// Escape character using backslash \

// New line
Console.WriteLine("Hello\nWorld");

// Tab
Console.WriteLine("Hello\tWorld");

// Escape quotation
Console.WriteLine("Hello \"World\"");

// Escape backslash
Console.WriteLine("C:\\New Directory\\");

// Exercise
// Generate the following mockup invoices with the correct formatting.
// Generating invoices for customer "Contoso Corp" ...
//
// Invoice: 1021           Complete!
// Invoice: 1022           Complete!
//
// Output Directory:

Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!\n");
Console.WriteLine("Output Directory:");

// Verbatism String Literal which keeps all whitespace and characters without escaping.
Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");

// Unicode escape characters
Console.WriteLine("\u3053\u3093\u306B\u3061\u306F");
