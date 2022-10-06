// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using RegexPin;
Solution sol = new Solution();

Console.WriteLine(sol.Validate("121317"));
Console.WriteLine(sol.Validate("1234"));
Console.WriteLine(sol.Validate("45135"));
Console.WriteLine(sol.Validate("89abc1"));
Console.WriteLine(sol.Validate("900876"));
Console.WriteLine(sol.Validate(" 4983"));