using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    internal class User
    {
        private string name;
        private List<BlogPost> posts;
        public string Name { get { return name; } set { name = value; } }
        public List<BlogPost> Posts { get { return posts; } set { } }
        public User(string name)
        {
            this.name = name;
            this.posts = new List<BlogPost>();
        }
        public void CreateBlogPost()
        {
            Console.WriteLine("Input title for post: ");
            string title = Console.ReadLine();
            Console.WriteLine("Input text for post: ");
            string text = Console.ReadLine();
            BlogPost post = new BlogPost(title, text);
            posts.Add(post);
        }
        public void CheckMyBlogs()
        {
            int count = 1;
            foreach (BlogPost post in posts)
            {
                Console.Write("#" + count++ + " ");
                Console.WriteLine(post);
            }
        }
        public override string ToString()
        {
            return string.Format($"User name: {name}");
        }
    }
}
