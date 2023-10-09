using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Interface.Classes
{
    enum MenuChoices { Login = 1, CreateUser, CheckUsers}
    enum MenuUser { AddBlog = 1, CheckMyBlogs, CheckBlogs, AddComment, CheckComments, Out }
    internal class Menu
    {
        public User currentUser;
        public List<User> users;
        public Menu() 
        {
            this.users = new List<User>();
        }
        public void AddUser()
        {
            Console.Write("Input name for user: ");
            string name = Console.ReadLine();
            if(users.Exists(user  => user.Name == name))
            {
                Console.WriteLine("User with this name already exist.\n" +
                    "Try again!");
                return;
            }
            User newUser = new User(name);
            users.Add(newUser);
        }
        public bool Login()
        {
            Console.Write("Input user name for login: ");
            string name = Console.ReadLine();
            currentUser = users.Find(user => user.Name == name);
            if (currentUser != null)
            {
                return true;
            }
            Console.WriteLine("There aren't users with this name!");
            return false;
        }
        public void CheckUsers()
        {
            Console.WriteLine("User list: ");
            foreach (User findUser in users)
            {
                Console.WriteLine(findUser);
            }
        }
        public void CheckBlogs()
        {
            foreach(User user in users)
            {
                Console.WriteLine($"The blog of the user with the name {user.Name}");
                user.CheckMyBlogs();
            }
        }
        public void AddComment()
        {
            Console.Write("Input author's name: ");
            string authorName = Console.ReadLine();
            User user = users.Find(user => user.Name == authorName);
            if (currentUser == null)
            {
                return;
            }
            Console.Write("Input a blog's number to add comment: ");
            int number = Int32.Parse(Console.ReadLine());
            user.Posts[number - 1].CreateComment(currentUser);
        }
        public void CheckComments()
        {
            Console.Write("Input author's name: ");
            string authorName = Console.ReadLine();
            User user = users.Find(user => user.Name == authorName);
            if (currentUser == null)
            {
                return;
            }
            Console.Write("Input a blog's number to add comment: ");
            int number = Int32.Parse(Console.ReadLine());
            foreach(Comment comment in user.Posts[number - 1].Comments)
            {
                Console.WriteLine(comment);
            }
        }
    }
}
