/*main driver code
*/
Solution sol = new();
string hex = "#00FF00";
bool isHex = sol.isHex(hex);
if(isHex == true)System.Console.WriteLine("true");
hex = "#CD5C58C";
isHex = sol.isHex(hex);
if(isHex == true)System.Console.WriteLine("true");
if(isHex == false)System.Console.WriteLine("false");
hex = "#CD5C5Z";
isHex = sol.isHex(hex);
if(isHex == true)System.Console.WriteLine("true");
if(isHex == false)System.Console.WriteLine("false");