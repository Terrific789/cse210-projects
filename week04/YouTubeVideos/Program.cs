using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Fry Plantain without a gas cooker", "The native kitchen", 500);
        video1.AddComment(new Comment("Chinedu", "I swear this plantain na fire!"));
        video1.AddComment(new Comment("Ada", "This one don make me hungry oo"));
        video1.AddComment(new Comment("Uche", "I try am and e sweet well!"));
        videos.Add(video1);

        Video video2 = new Video("Introduction to Java for Beginners", "CodeWithIzunna", 1500);
        video2.AddComment(new Comment("Samuel", "You dey teach like better teacher!"));
        video2.AddComment(new Comment("Blessing", "Nice breakdown! I understand everything"));
        video2.AddComment(new Comment("Tope", "God bless you bro"));
        videos.Add(video2);

        Video video3 = new Video("Naija Street Food Tour", "BukkaBoy", 600);
        video3.AddComment(new Comment("Lola", "Na this food make sense pass"));
        video3.AddComment(new Comment("Yusuf", "I sabi that woman wey sell amala 😂"));
        video3.AddComment(new Comment("Zubby", "Next time carry me go!"));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine("\n-----------------------------\n");
        }
    }
}
