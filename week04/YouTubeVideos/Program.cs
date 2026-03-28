using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video();
        v1._title = "Learning C# Basics";
        v1._author = "Code Academy";
        v1._length = 600;

        Comment c1 = new Comment();
        c1._name = "Joel";
        c1._text = "Very helpful video!";
        v1.AddComment(c1);

        Comment c2 = new Comment();
        c2._name = "Sarah";
        c2._text = "I understand loops now!";
        v1.AddComment(c2);

        Comment c3 = new Comment();
        c3._name = "Mike";
        c3._text = "Great explanation!";
        v1.AddComment(c3);

        videos.Add(v1);

        // Video 2
        Video v2 = new Video();
        v2._title = "OOP Explained";
        v2._author = "Tech Guru";
        v2._length = 800;

        v2.AddComment(new Comment { _name = "Anna", _text = "This was confusing but helpful." });
        v2.AddComment(new Comment { _name = "Tom", _text = "Nice examples!" });
        v2.AddComment(new Comment { _name = "Lisa", _text = "Loved it!" });

        videos.Add(v2);

        // Video 3
        Video v3 = new Video();
        v3._title = "Data Structures";
        v3._author = "CS Master";
        v3._length = 900;

        v3.AddComment(new Comment { _name = "John", _text = "Stacks finally make sense!" });
        v3.AddComment(new Comment { _name = "Grace", _text = "Queues are easy now!" });
        v3.AddComment(new Comment { _name = "Paul", _text = "Very detailed." });

        videos.Add(v3);

        // Display all videos
        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}