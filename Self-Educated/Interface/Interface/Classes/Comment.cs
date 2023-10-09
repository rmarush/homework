using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    internal class Comment : IComment
    {
        private string author;
        private string text;
        private DateTime publishDate;
        public string Author { get { return author; } set {  author = value; } }
        public string Text { get { return  text; } set { text = value; } }
        public DateTime PublishDate { get {  return publishDate; } set {  publishDate = value; } }
        public Comment(string author, string text)
        {
            this.author = author;
            this.text = text;
            this.publishDate = DateTime.Now;
        }
        public override string ToString()
        {
            return string.Format($"Author: {author}\n" +
                $"{text}+\n" +
                $"{publishDate}");
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
