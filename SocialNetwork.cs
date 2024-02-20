using System;

namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }
    }

    class Post
    {
        private string text;

        // Constructor to initialize the text property
        public Post()
        {
           Console.WriteLine("New post");
        }

        // Property for the text member
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public void ShowPost()
        {
            Console.WriteLine(text);
        }

        // Renamed ShowPost2 to better reflect its purpose
    }
}
