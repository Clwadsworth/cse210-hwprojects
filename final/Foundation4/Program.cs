using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // create a list to cycle through the foreach loop to save on retyping repeatitive codes
        List<Activity> activeRecord = new List<Activity>();

        // input the fixed values for result checking also ask by assignment
        activeRecord.Add(new Running("July 27th 2026", 20, 2.6));
        activeRecord.Add(new Cycling("June 6th 2026", 50, 14.6));
        activeRecord.Add(new Swimming("July 1st 2026", 30, 15));

        // said loop that was mentioned that will work with the List<Activity>
        foreach (Activity activity in activeRecord)
        {
            Console.WriteLine(activity.GetSummary());
            // added this writeline to create spacing with the console lines to space out results
            Console.WriteLine("");
        }
    }
}