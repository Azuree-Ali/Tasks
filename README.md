// Search Task 1 : 
1. Why is the output $30.00?
The format specifier :C stands for Currency. It tells C# to format the number as money based on the
system's regional settings. Since the system culture is set to US, the result is displayed as $30.00.
===============================================================.
2. What is its benefit?
Currency formatting is useful when displaying prices, salaries, or financial values. It automatically
adds the correct currency symbol, decimal places, and separators according to the user's locale.
===============================================================.
3. Another example with a different specifier
Example using the :F2 specifier (Fixed-point with 2 decimal places):
double x = 15;
double y = 4;
Console.WriteLine($"Equation: 15 / 4 = {x / y:F2}");
// The output is uploaded with the solution in Search Task folder
