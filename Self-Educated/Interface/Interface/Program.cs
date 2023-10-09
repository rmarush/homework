using Interface.Classes;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            bool userIsLogged = false;
            while(true)
            {
                Console.WriteLine("---MAIN MENU---\n" +
                    "1 - Login\n" +
                    "2 - Create User\n" +
                    "3 - Check Users");
                switch(Int32.Parse(Console.ReadLine())) 
                {
                    case (int)MenuChoices.Login:
                        userIsLogged = menu.Login();
                        Console.Clear();
                        break;
                    case (int)MenuChoices.CreateUser:
                        menu.AddUser();
                        Console.Clear();
                        break;
                    case (int)MenuChoices.CheckUsers:
                        menu.CheckUsers();
                        break;
                    default:
                        Console.WriteLine("Input error, try again!\n");
                        break;
                }
                while(userIsLogged)
                    {
                        Console.WriteLine("---USER MENU---\n" +
                                            "1 - Add Blog\n" +
                                            "2 - Check My Blogs\n" +
                                            "3 - Check All Blogs\n" +
                                            "4 - Add Comment\n" +
                                            "5 - Check Comments\n" +
                                            "6 - Out");
                        switch (Int32.Parse(Console.ReadLine()))
                        {
                            case (int)MenuUser.AddBlog:
                                menu.currentUser.CreateBlogPost();
                                Console.Clear();
                                break;
                            case (int)MenuUser.CheckMyBlogs:
                                menu.currentUser.CheckMyBlogs();
                                break;
                            case (int)MenuUser.CheckBlogs:
                                menu.CheckBlogs();
                                break;
                            case (int)MenuUser.AddComment:
                                menu.AddComment();
                                Console.Clear();
                                break;
                            case (int)MenuUser.CheckComments:
                                menu.CheckComments();
                                break;
                            case (int)MenuUser.Out:
                                userIsLogged = false;
                                Console.Clear();
                            break;
                            default:
                                Console.WriteLine("Input error, try again!\n");
                                break;
                        }
                }
            }
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