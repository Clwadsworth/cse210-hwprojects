using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // need a way to track the list of videos
        List<Video> videos = new List<Video>();

        // first one of the videos: we will list everything for the video information 
        Video video1 = new Video("C# Encapsulation Explained", "CodeCraft", 600);
        video1.AddComment(new Comment("Alice", "Great explanation of private field!"));
        video1.AddComment(new Comment("Bob", "This made abstraction click for me."));
        video1.AddComment(new Comment("Charlie", "Can you do an episode on inheritance next?"));
        videos.Add(video1);

        // Second video with all information
        Video video2 = new Video("10 Linters You Need", "DevToolsDaily", 350);
        video2.AddComment(new Comment("Dave", "I use the third one every day."));
        video2.AddComment(new Comment("Emma", "Extremely helpful summary, thanks."));
        video2.AddComment(new Comment("Frank", "Does this work nicely in VS Code?"));
        videos.Add(video2);

        // final video with all information
        Video video3 = new Video("Lo-Fi Coding Beats for Nomalizing Databases", "ChillQuery", 7200);
        video3.AddComment(new Comment("Grace", "Prefect background track for mapping out ERDs."));
        video3.AddComment(new Comment("Hank", "Passed my database practical exam listening to this."));
        video3.AddComment(new Comment("Ivy", "The bass drop during the third normal form what legendary!"));
        videos.Add(video3);

        // iteration for the output details
        Console.WriteLine("----- YouTube Video Logger -----\n");
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}