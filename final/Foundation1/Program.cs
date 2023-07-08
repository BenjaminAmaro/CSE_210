using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to Overcome Fear of the sea", "Ryan Green", 640);
        Video video2 = new Video("Running 200 Miles", "Rich Roll", 350);
        Video video3 = new Video("My Morning Routine", "steph leclerc", 200);
        Video video4 = new Video("The World Biggest Bike", "David Smith", 1250);

        video1.AddComment("Benjamin", "I have never travel by boat, thanks for the information I might start today");
        video1.AddComment("Roxane", "this is so useful thanks! ");
        video1.AddComment("Uriel", "this does not work");
        video2.AddComment("Raul", "Wow you inspire me to do one now");
        video2.AddComment("Albert", "Wow great experience ");
        video2.AddComment("Joshua", "i did this race last year!  ");
        video3.AddComment("Brian", "not really interesting");
        video4.AddComment("Roberto", "I cant wait to see it in person");
        video4.AddComment("Jonh", "it doesnt look that big");
        video4.AddComment("Alex", "there are good races in that town");
        video4.AddComment("Justin", "waste of money");
        video4.AddComment("Yoland", "there is one in my country");
        video4.AddComment("Richard", "it is a work of art");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.VideoInfo();
        }
    }
}