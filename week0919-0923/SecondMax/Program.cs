// See https://aka.ms/new-console-template for more information
using SecondMax;
string[] SampleStrings = {"1 2 3","10 15 5","100 999 500"};

Solution sol = new Solution();
for(int i = 0; i < 3; i++){
    int mid = sol.GetSecondMaxFromString(SampleStrings[i]);
    //Console.WriteLine("The second-maximum number in the sequence is");
    Console.WriteLine(mid);
}