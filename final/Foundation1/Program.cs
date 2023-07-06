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
        comment.AddingComments(com1);
        comment.AddingComments(com2);
        comment.AddingComments(com3);
        //Displaying video 1
        Console.WriteLine($"Video Name: {video._title} ");
        Console.WriteLine($"Author: {video._author} ");
        Console.WriteLine($"Duration: {video._durationinsec} sec ");
        Console.WriteLine($"Numbers of comments: {comment.CommentsNum()}");
        comment.DisplayComments();
        
        //Setting VIDEO 2
        Console.WriteLine("");
        Video video2 = new Video("Butter Cookies", "Alicia James", 300);
        Comment com4 = new Comment("Monique", "The cookies were delicious.");
        Comment com5 = new Comment("Adrian", "I prefer use oatmeal flour.");
        Comment com6 = new Comment("Johny Deep", "Minute 2, what was the ingredient you used?.");
        Comment com7 = new Comment("Maria Carey", "Great idea to start a business.");
        //Adding Comments
        Comment comment2 = new Comment();
        comment2.AddingComments(com4);
        comment2.AddingComments(com5);
        comment2.AddingComments(com6);
        comment2.AddingComments(com7);
        //Displaying video 2
        Console.WriteLine($"Video Name: {video2._title} ");
        Console.WriteLine($"Author: {video2._author} ");
        Console.WriteLine($"Duration: {video2._durationinsec} sec ");
        Console.WriteLine($"Numbers of comments: {comment2.CommentsNum()}");
        comment2.DisplayComments();

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
        comment3.AddingComments(com8);
        comment3.AddingComments(com9);
        comment3.AddingComments(com10);
        comment3.AddingComments(com11);
        comment3.AddingComments(com12);
        //Displayig Video 3
        Console.WriteLine($"Video Name: {video3._title} ");
        Console.WriteLine($"Author: {video3._author} ");
        Console.WriteLine($"Duration: {video3._durationinsec} sec ");
        Console.WriteLine($"Numbers of comments: {comment3.CommentsNum()}");
        comment3.DisplayComments();




    }
   
}