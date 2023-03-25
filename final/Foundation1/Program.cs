using System;

class Program
{
    static void Main(string[] args)
    {
        comment com1 = new comment("george", "enjoyed");
        comment com2 = new comment("fallacy", "liked");
        comment com3 = new comment("severus", "boring");
        comment com4 = new comment("lolly", "I dont get it");
        List<comment> comments1 = new List<comment>();
        comments1.Add(com1);
        comments1.Add(com2);
        comments1.Add(com3);
        comments1.Add(com4);
        ///
        comment com5 = new comment("doubter", "sus");
        comment com6 = new comment("fallacy", "liked this more");
        comment com7 = new comment("legend27", "I could do better");
        comment com8 = new comment("makeupGirl77", "so cute!");
        List<comment> comments2 = new List<comment>();
        comments2.Add(com5);
        comments2.Add(com6);
        comments2.Add(com7);
        comments2.Add(com8);
        ///
        comment com9 = new comment("george", "your best video yet!");
        comment com10 = new comment("fallacy", "liked");
        comment com11 = new comment("severus", "can you make something interesting for once?");
        comment com12 = new comment("lolly", "this finaly makes sense");
        List<comment> comments3 = new List<comment>();
        comments3.Add(com9);
        comments3.Add(com10);
        comments3.Add(com11);
        comments3.Add(com12);
        ///
        video vid1 = new video(comments1, "how to build a minecraft house", "floydssss", 500);
        video vid2 = new video(comments1, "how to do makeup", "ThatGirlNextDoor", 1000);
        video vid3 = new video(comments1, "how to build a simpler minecraft house", "floydssss", 700);
        ///
        List<video> videos = new List<video>();
        videos.Add(vid1);
        videos.Add(vid2);
        videos.Add(vid3);
        ///
        foreach(video item in videos)
        {
            item.display();
        }
    }
}