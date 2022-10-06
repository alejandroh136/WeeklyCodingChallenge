namespace Friday13{
    public class Solution{
        public bool HasFriday13(int month, int year){
            DateTime dateTime = new DateTime(year,month,13,12,0,0);//.Today.DayOfTheWeek;
            //System.Console.WriteLine(mydate.DayOfWeek);
            //return false;
            if(dateTime.DayOfWeek == DayOfWeek.Friday){
                return true;
            }
            else{
                return false;
            }
        }
    }
}