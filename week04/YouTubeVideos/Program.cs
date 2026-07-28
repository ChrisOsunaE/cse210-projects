using System;
using System.Collections.Generic; // Asegúrate de incluir esto para usar List

class Program
{
    static void Main(string[] args)
    {
        // 1. Crear una lista para almacenar los videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("First Video", "This is the first video", "Author1", 120);
        video1.addComment(new Comment("first comment", "User1", DateTime.Now));
        video1.addComment(new Comment("Better don't see this!", "User2", DateTime.Now));
        videos.Add(video1);

        Video video2 = new Video("Second Video", "This is the second video", "Author2", 300);
        video2.addComment(new Comment("Great video!", "User3", DateTime.Now));
        video2.addComment(new Comment("I learned a lot", "User4", DateTime.Now));
        videos.Add(video2);

        Video video3 = new Video("Third Video", "This is the third video", "Author3", 180);
        video3.addComment(new Comment("Nice tutorial!", "User5", DateTime.Now));
        video3.addComment(new Comment("Thanks for sharing!", "User6", DateTime.Now));
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Description: {video.GetDescription()}");
            Console.WriteLine($"Duration: {video.GetTime()} seconds");
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetText()} by {comment.GetAuthor()} at {comment.GetTimestamp()}");
            }
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine(); 
            Console.ReadLine();
        }   

    }
}