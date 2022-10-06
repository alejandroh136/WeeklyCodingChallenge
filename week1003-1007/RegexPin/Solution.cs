
namespace RegexPin{
using System.Text.RegularExpressions;    
    public class Solution{
        public bool Validate(string s){
            var regex = @"^(\d{4}$|\d{6}$)";
            Match match = Regex.Match(s,regex);
            if(match.Success){
                return true;
            }
            else{
                return false;
            }
        }
    }
}