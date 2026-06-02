using System;

class Program
{
    static void Main(string[] args)
    {
        // adding the addresses for each class
        string[] reception1 = {"5647 Deer Tracks Drive", "Nowhere", "MT", "86000", "USA"};
        string[] lecture1 = {"456 Center St.", "Boise", "ID", "85363", "USA"};
        string[] gathering1 = {"5 Carter Campsite", "Sutton", "WA", "94635", "USA"};

        Receptions reception = new Receptions(   
            "Mongomery Wedding Reception",
            "An evening with the newly wedded couple",
            "July 24th, 2017",
            "3:30 pm",
            reception1,
            "smithandco@hotmail.com"
        );

        Lectures lecture = new Lectures(
            "Smith Showcase",
            "A open talk about code and why it should be in your home",
            "December 14th 2024",
            "9:00 pm",
            lecture1,
            "Todd and Samantha Smith",
            110
        );

        OutdoorGatherings gathering = new OutdoorGatherings(
            "Great Outdoor Revieval",
            "Spiritual conference to awaken the senses to the Spirit",
            "June 1st 2026",
            "5:00 pm",
            gathering1,
            "80F, with slight breeze"
        );
    }
}