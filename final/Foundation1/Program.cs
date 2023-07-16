using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        //Setting VIDEO 1
        Console.WriteLine("");
        Video video = new Video("Making Math", "Sabrina Carpenter", 120);
        Comment com1 = new Comment("Aby", "Finally I understood.");
        Comment com2 = new Comment("Mary", "Great job!.");
        Comment com3 = new Comment("John", "I loved the color you used, now I never forget it!.");
        //Adding Comments
        Comment comment = new Comment();
        video.AddingComments(com1);
        video.AddingComments(com2);
        video.AddingComments(com3);
        //Displaying video 1
        Console.WriteLine($"Video Name: {video._title} ");
        Console.WriteLine($"Author: {video._author} ");
        Console.WriteLine($"Duration: {video._durationinsec} sec ");
        Console.WriteLine($"Numbers of comments: {video.GetComNumber()}");
        video.DisplayComments();
        
        //Setting VIDEO 2
        Console.WriteLine("");
        Video video2 = new Video("Butter Cookies", "Alicia James", 300);
        Comment com4 = new Comment("Monique", "The cookies were delicious.");
        Comment com5 = new Comment("Adrian", "I prefer use oatmeal flour.");
        Comment com6 = new Comment("Johny Deep", "Minute 2, what was the ingredient you used?.");
        Comment com7 = new Comment("Maria Carey", "Great idea to start a business.");
        //Adding Comments
        Comment comment2 = new Comment();
        video2.AddingComments(com4);
        video2.AddingComments(com5);
        video2.AddingComments(com6);
        video2.AddingComments(com7);
        //Displaying video 2
        Console.WriteLine($"Video Name: {video2._title} ");
        Console.WriteLine($"Author: {video2._author} ");
        Console.WriteLine($"Duration: {video2._durationinsec} sec ");
        Console.WriteLine($"Numbers of comments: {video2.GetComNumber()}");
        video2.DisplayComments();

        //Setting VIDEO 3
        Console.WriteLine("");
        Video video3 = new Video("Guitar for beginners", "Zoe Mario", 600);
        Comment com8 = new Comment("Miranda", "Thanks for sharing this course, now I am learning.");
        Comment com9 = new Comment("Samara", "I love that song!");
        Comment com10 = new Comment("John Denver", "Could you do the song 'When you are here' from Mary Osborn?");
        Comment com11= new Comment("Stuard", "My daughter is learnig so well! thank you so much!");
        Comment com12 = new Comment("Miranda", "It would help a good microphone.");
        //Adding Comments
        Comment comment3 = new Comment();
        video3.AddingComments(com8);
        video3.AddingComments(com9);
        video3.AddingComments(com10);
        video3.AddingComments(com11);
        video3.AddingComments(com12);
        //Displayig Video 3
        Console.WriteLine($"Video Name: {video3._title} ");
        Console.WriteLine($"Author: {video3._author} ");
        Console.WriteLine($"Duration: {video3._durationinsec} sec ");
        Console.WriteLine($"Numbers of comments: {video3.GetComNumber()}");
        video3.DisplayComments();




    }
   
}