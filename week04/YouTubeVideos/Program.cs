using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to Build a Budget PC", "TechWithAlex", 540);
        video1.AddComment(new Comment("Norlin", "This was really helpful, thank you."));
        video1.AddComment(new Comment("Maria", "Great explanation and very easy to follow."));
        video1.AddComment(new Comment("David", "I liked the parts list you included."));
        video1.AddComment(new Comment("Sofia", "Please make one about gaming laptops too."));

        Video video2 = new Video("Top 5 Productivity Apps", "DailyFocus", 420);
        video2.AddComment(new Comment("John", "I use two of these every day."));
        video2.AddComment(new Comment("Camila", "Very useful recommendations."));
        video2.AddComment(new Comment("Eric", "The note-taking app is my favorite."));
        video2.AddComment(new Comment("Ana", "Nice video and straight to the point."));

        Video video3 = new Video("Beginner C# Tutorial", "CodeMaster", 780);
        video3.AddComment(new Comment("Luis", "This made classes much easier to understand."));
        video3.AddComment(new Comment("Andrea", "Thanks for explaining objects so clearly."));
        video3.AddComment(new Comment("Kevin", "Can you do one on inheritance next?"));
        video3.AddComment(new Comment("Paul", "Best beginner tutorial I have seen so far."));

        Video video4 = new Video("Richmond Food Tour", "TravelBites", 615);
        video4.AddComment(new Comment("Elena", "Now I want to visit Richmond."));
        video4.AddComment(new Comment("Chris", "Everything looked amazing."));
        video4.AddComment(new Comment("Paula", "The burger spot looked like the best one."));
        video4.AddComment(new Comment("Miguel", "Really fun video and great editing."));

        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length (seconds): {video.GetLengthInSeconds()}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
    }
}