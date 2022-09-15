public class Solution{
    public Solution(){}
    public int nextPrime(int number){
        if(checkPrime(number)){
            return number;
        }
        else{
            return(this.nextPrime(number+1));
        }
    }
    private bool checkPrime(int number){//check if prime
        int checkupto = ((int)Math.Floor((double)number/2));
        for(int i = 2; i < checkupto; i++){
            //not prime exit
            if(number%i == 0){
                return false;
            }
        }
        //if we make it this far, it is prime
        return true;
    }
}