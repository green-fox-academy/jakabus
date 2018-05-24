using System;

namespace PostIt
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt Idea1 = new PostIt("Orange", "Idea1", "Blue");
            PostIt Awesome = new PostIt("Pink", "Awesome", "Black");
            PostIt Superb = new PostIt("Yellow", "Superb", "Green");

            Console.WriteLine(Idea1.TextColor);
            

            Console.ReadKey();
        }
    }
    public struct PostIt
    {
        public string Backgroundcolor;
        public string Text;
        public string TextColor;

        public PostIt(string backgroundcolor, string text, string textColor)
        {
            Backgroundcolor = backgroundcolor;
            Text = text;
            TextColor = textColor;
        }
    }
}

