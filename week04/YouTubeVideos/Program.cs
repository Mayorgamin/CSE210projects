using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        // Video 1
        Video video1 = new Video("The Pursuit of Happiness", "BYU Speeches", 1983);
        Comment comment1_1 = new Comment("@kimberlyolsen9416", "Awesome! And reciting Section 4! Brought tears to my eyes ❤");
        Comment comment2_1 = new Comment("@bearidler5926", "Magnificent presentation, thank you.");
        Comment comment3_1 = new Comment("@chandraau1475", "What a brilliant talk. Incredibly enlightening, with a challenge to do and be better each day.");
        video1.AddComment(comment1_1);
        video1.AddComment(comment2_1);
        video1.AddComment(comment3_1);
        videos.Add(video1);
        // Video 2
        Video video2 = new Video("Our Prayer to Thee | The Tabernacle Choir", "Tabernacle Choir at Temple Square", 295);
        Comment comment1_2 = new Comment("@williamhoward2731", "I wish to thank you for sharing this Christian music video with me . Amen");
        Comment comment2_2 = new Comment("@AlexRay-pw6ro", "God bless 🙏");
        Comment comment3_2 = new Comment("@Ja.pheth_", "Peace 😌😌");
        video2.AddComment(comment1_2);
        video2.AddComment(comment2_2);
        video2.AddComment(comment3_2);
        videos.Add(video2);
        // Video 3
        Video video3 = new Video("Temple Building Across the Globe is Exploding | October 2024 Edition", "Called to Share", 209);
        Comment comment1_3 = new Comment("@mariebarnhurst1355", "Every temple increases the power of the Lord Jesus Christ! I love these videos!");
        Comment comment2_3 = new Comment("@AnticipatingChristsreturn", "Ahhhhh I can’t wait for this!!! These videos that you do about the temples, always have me sobbing like a baby!!!");
        Comment comment3_3 = new Comment("@truthfromearth", "I love every single edition of this, in all its glory.");
        video3.AddComment(comment1_3);
        video3.AddComment(comment2_3);
        video3.AddComment(comment3_3);
        videos.Add(video3);
        //Loop through the videos list
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }


    }
}