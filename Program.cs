using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            String myName = "Abdurrahmon Badmus";
            dynamic myTrack = "Backend";
            var myReason = "I am learning backend development because i want to add it to my knowledge of front-end so i can become a full-stack developer.";
            Console.WriteLine("Hello " + myName +", I am in " +myTrack + " of Wella Schools.");
            Console.WriteLine(myReason);
        }
    }
}
