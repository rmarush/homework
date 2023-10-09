using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Classes
{
    internal interface IComment
    {
        string Author { get; set; }
        string Text { get; set; }
        DateTime PublishDate { get; set; }
    }
}
/*
 * Блог з коментарями: Створіть простий блог. Створіть інтерфейс "IBlogPost", який має властивості для заголовку, 
 * тексту і дати публікації. Реалізуйте цей інтерфейс у класі "BlogPost". 
 * Створіть інтерфейс "IComment", який має властивості для автора, тексту і дати коментаря. 
 * Реалізуйте цей інтерфейс у класі "Comment". 
 * Дайте можливість додавати коментарі до блог-постів і виводити їх. 
 */