namespace  LargetGap
{
    public class Solution{
        public int LargetGap(int[] somearray){
            Array.Sort(somearray);
            int largestGap = 0;
            for(int i = 0; i < somearray.Length-1; i++){
                int gap = Math.Abs(somearray[i] - somearray[i+1]);
                if(gap > largestGap){
                    largestGap = gap;
                }
            }
            return largestGap;
        }
    }
}