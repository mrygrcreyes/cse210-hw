using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        // video1
        Video vid1 = new Video("Amazing Custard Cream French Toast Recipe! Super delicious!", "Meliniskitchen", 264);
        vid1.Comment("Cooking With KF", "This French toast is unique and it is absolutely delicious, I want to try it.");
        vid1.Comment("Marvin M", "The French toast with custard cream is super delicious.");
        vid1.Comment("Carey", "I always add cinnamon to my French toast mixture. This looks so good!");
        _videos.Add(vid1);

        // video2
        Video vid2 = new Video("Total Home Renovation in Only FOUR WEEKS | Help I Wrecked My House", "HGTV", 559);
        vid2.Comment("Amelia O'Dell", "Absolutely love it! And the realistic amount of seating in the living room is so key. Massive upgrade");
        vid2.Comment("Kasandra Mckenna", "I love it when the wife is moved to tears this one has me tearing up. I would react the same way!");
        vid2.Comment("Still I Rise!!", "I totally felt the relief that the mom-to-be felt.  It was all done, and all done so beautifully!!!   Well done!!! ");
        _videos.Add(vid2);

        // video3
        Video vid3 = new Video("Shadow Ace Shines on the AGT Stage with Unforgettable Audition", "America's Got Talent", 252);
        vid3.Comment("Willy Hinojosa", "I was in the audience that day, it was truly the best audition of the day!!");
        vid3.Comment("Bri & Jessie", "wow!! seeing his happiness after seeing ALL the judges stand made me THAT much happier for him!! amazing!!!");
        vid3.Comment("DonoVideo", "This is what talent looks like. You are a storyteller. I hope you make it to the finals.");
        _videos.Add(vid3);

        foreach (Video video in _videos)
        {
            video.GetVideo();
            Console.WriteLine();
        }
    }
}
