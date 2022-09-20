namespace SecondMax{
    public class Solution{
        /* Accepts three numbers as spaced separated string and returns the second-maximum number among the three
        // RunFromReadLine method is the runner for the challenge it accepts one value which will be the number of
        // time that it will accept line inputs. Then for each line it will run GetSecondMaxFromString 
        // If in case I need to write a test for it, I should just use a for loop in a test and just run
        // GetSecondMaxFromString
        */ 
        private bool _convertSucceeded = true;
        public int SecondMax(int a, int b, int c){
            // only given 3 digits
            List<int> intList = new List<int>{a,b,c};
            intList.Sort();
            return intList[1];
        }
        //helper method
        public List<int> ConvertStringToList(string s){
            List<int> intList = new List<int>();
            foreach(string x in s.Split(" ")){
                int temp;
                if(Int32.TryParse(x, out temp)){
                    intList.Add(temp);
                }
                else{
                    this._convertSucceeded = false;
                    return new List<int>();
                }
            }
            return intList;
        }
        //returns true if it was able to convert string to a list of integers
        public bool SuccessConvert(){
            return this._convertSucceeded;
        }
        //given a string which should contain 3 numbers in a spaced separated string
        public int GetSecondMaxFromString(string s){
            List<int> intList = this.ConvertStringToList(s);
            if(this._convertSucceeded){
                return this.SecondMax(intList[0],intList[1],intList[2]);
            }
            else{
                return -1;
            }
        }
        //runner for challenge as described. first integer is the number of inputs. sequential inputs will 
        //be a list spaced separated string contain 3 integers
        public void RunFromReadLine(){
            string inputS = Console.ReadLine();
            int howmany;
            Int32.TryParse(inputS,out howmany);
            for(int i = 0; i < howmany; i++){
                inputS = Console.ReadLine();
                int x = this.GetSecondMaxFromString(inputS);
                this.PrintMid(x);
            }
        }
        //helper function
        private void PrintMid(int x){
            Console.WriteLine(x);
        }
    }
}