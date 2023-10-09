using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    internal class BlogPost : IBlogPost
    {
        private string title;
        private string text;
        private DateTime publishDate;
        private List<Comment> comments;
        public string Title { get { return title; } set {  title = value; } }
        public string Text { get { return text; } set { text = value; } }
        public DateTime PublishDate { get {  return publishDate; } set {  publishDate = value; } }
        public List<Comment> Comments { get { return comments; } set { comments = value; } }
        public BlogPost(string title, string text)
        {
            this.title = title;
            this.text = text;
            this.publishDate = DateTime.Now;
            this.comments = new List<Comment>();
        }
        public void CreateComment(User user)
        {
            Console.WriteLine("Input your comment: ");
            string textForComment = Console.ReadLine();
            Comment comment = new Comment(user.Name, textForComment);
            comments.Add(comment);
            Console.WriteLine("Your comment was added!");
        }
        public override string ToString()
        {
            return string.Format($"Title: {title}\n" +
                $"Titile: {text}\n" +
                $"Date: {publishDate}");
        }
    }
}
/*
 * Блог з коментарями: Створіть простий блог. Створіть інтерфейс "IBlogPost", який має властивості для заголовку, 
 * тексту і дати публікації. Реалізуйте цей інтерфейс у класі "BlogPost". 
 * Створіть інтерфейс "IComment", який має властивості для автора, тексту і дати коментаря. 
 * Реалізуйте цей інтерфейс у класі "Comment". 
 * Дайте можливість додавати коментарі до блог-постів і виводити їх. 
 */