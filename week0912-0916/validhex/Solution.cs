public class Solution{
    public Solution(){}
    public bool isHex(string s){
        if(s.Length < 7 ||  s.Length > 7 ){
            return false;
        }
        if(s[0] != '#'){
            return false;
        }
        for(int i = 1; i < 7; i++){
            //System.Console.WriteLine("at index " + i);
            char c = s[i];
            //System.Console.WriteLine(c + "\n");
            if(c < 48 || c > 70){
                return false;
            }    
        }
        return true;
    }
}