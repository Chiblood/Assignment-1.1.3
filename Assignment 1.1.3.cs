// 3. Write a C# program to print the result of dividing two numbers. Print the quotient and the remainder as well. Get the input from the user.

float dividend, divisor;

Console.WriteLine("Enter the dividend: ");
float.TryParse(Console.ReadLine(), out dividend);

Console.WriteLine("Enter the divisor: ");
float.TryParse(Console.ReadLine(), out divisor);

float quotient = (float)(dividend / divisor);
int remainder = (int)dividend % (int)divisor;
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Remainder: {remainder}");