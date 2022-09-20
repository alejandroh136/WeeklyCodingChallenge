namespace SumDigitsInString{
    public class Solution{
        public int SumDigitsInString(string s){
            int total = 0;
            for(int i = 0; i < s.Length; i++){
                int temp;
                string tmps = s[i].ToString();
                if(Int32.TryParse(tmps, out temp)){
                    total = total + temp;
                }
            }
            return total;
        }
        //runner for challenge as described. first integer is the number of inputs. sequential inputs will 
        //be a string that will sum all digits
        public void RunFromReadLine(){
            string inputS = Console.ReadLine();
            int howmany;
            Int32.TryParse(inputS,out howmany);
            for(int i = 0; i < howmany; i++){
                inputS = Console.ReadLine();
                int x = this.SumDigitsInString(inputS);
                this.PrintTotal(x);
            }
        }
        //helper function
        private void PrintTotal(int x){
            Console.WriteLine(x);
        }
    }
}