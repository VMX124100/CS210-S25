public class Program
{
    public static void Main(string[] args)
    {

        List<Video> videos = new List<Video>();


        Video video1 = new Video("C# Basics", "John Debil", 300);
        video1.AddComment(new Comment("Alice", "Great introduction to C#!"));
        video1.AddComment(new Comment("Bob", "Very clear and helpful."));
        video1.AddComment(new Comment("Carol", "I loved the examples!"));
        videos.Add(video1);

        Video video2 = new Video("Advanced C#", "Jane Foster", 600);
        video2.AddComment(new Comment("Dave", "This is exactly what I needed."));
        video2.AddComment(new Comment("Eve", "Well explained and structured."));
        video2.AddComment(new Comment("Frank", "Please make more videos like this."));
        video2.AddComment(new Comment("Grace", "Fantastic ways to explain advanced topics."));
        videos.Add(video2);

        Video video3 = new Video("SQL Tutorial", "John Debil", 400);
        video3.AddComment(new Comment("Hannah", "SQL is awesome after watching this!"));
        video3.AddComment(new Comment("Ian", "This cleared many doubts."));
        video3.AddComment(new Comment("Jack", "Great tips and tricks for SQL."));
        videos.Add(video3);

        Video video4 = new Video("JavaScript Basics", "Jane Foster", 900);
        video4.AddComment(new Comment("Laura", "Good start for JavaScript beginners."));
        video4.AddComment(new Comment("Matt", "Can't wait for more advanced topics."));
        video4.AddComment(new Comment("Nina", "Very well presented."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}