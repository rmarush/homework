namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskOne();
            TaskTwo();
            TaskThree();
        }
        static void TaskOne()
        {
            string path1 = @"D:\data.txt";
            string path2 = @"D:\rez.txt";
            int choice = 0;
            string info;
            bool validInput = false;
            do
            {
                try
                {
                    Console.Write("Input a choice 1/2: ");
                    choice = Int32.Parse(Console.ReadLine());
                    if (choice != 1 && choice != 2)
                    {
                        throw new ApplicationException("Input error! Try again!");
                    }
                    validInput = true;
                }
                catch (ApplicationException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } while (!validInput);
            switch (choice)
            {
                case 1:
                    using (StreamReader sr = new StreamReader(path1))
                    {
                        info = sr.ReadToEnd();
                    }
                    using (StreamWriter sw = new StreamWriter(path2))
                    {
                        sw.Write(info);
                    }
                    Console.WriteLine("Information was writen to file!");
                    break;
                case 2:
                    info = File.ReadAllText(path1);
                    File.WriteAllText(path2, info);
                    Console.WriteLine("Information was writen to file!");
                    break;
            }
        }
        static void TaskTwo()
        {
            string dirName = @"D:\";
            try
            {
                var directory = new DirectoryInfo(dirName);
                DirectoryInfo[] dirs = directory.GetDirectories();
                FileInfo[] files = directory.GetFiles();
                using (StreamWriter sw = new StreamWriter(@"D:\DirectoryD.txt"))
                {
                    sw.WriteLine("Information about Directory: ");
                    foreach (DirectoryInfo dir in dirs)
                    {
                        sw.WriteLine($"Name: {dir.Name}");
                        sw.WriteLine($"Creation time: {dir.CreationTime}");
                        sw.WriteLine($"Parent: {dir.Parent}");
                        sw.WriteLine();
                    }
                    sw.WriteLine("Information about Files: ");
                    foreach (FileInfo file in files)
                    {
                        sw.WriteLine($"Name: {file.Name}");
                        sw.WriteLine($"Length: {file.Length}");
                        sw.WriteLine($"Parent Directory: {file.Directory}");
                        sw.WriteLine();
                    }
                }
                Console.WriteLine("Information about directory D was written to the file!");
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("Unauthorized access: " + e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found: " + e.Message);
            }
            catch (IOException e)
            {
                Console.WriteLine("I/O error: " + e.Message);
            }
        }
        static void TaskThree()
        {
            string dirName = @"D:\";
            try
            {
                DirectoryInfo directory = new DirectoryInfo(dirName);
                FileInfo[] txtFiles = directory.GetFiles("*.txt");
                foreach(FileInfo file in txtFiles)
                {
                    try
                    {
                        string text = File.ReadAllText(file.FullName);
                        Console.WriteLine($"Text from {file.Name}:");
                        Console.WriteLine(text);
                        Console.WriteLine(new string('-', 50));
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        Console.WriteLine($"Unauthorized access to {file.Name}: " + e.Message);
                    }
                    catch (IOException e)
                    {
                        Console.WriteLine($"I/O error while reading {file.Name}: " + e.Message);
                    }
                }
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Directory not found: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("An unexpected error occurred: " + e.Message);
            }
        }
    }
}

/*
 * Read and write all data from data.txt into rez.txt files, by using (Catch appropriative exceptions):
 * StreamReader StreamWriter
 * File.WriteAllText
 * Write into file ‘DirectoryC.txt’ information (e.g. name, type, size) about all directories and files from disc D on your computer. Catch appropriative exceptions.
 * Select from directory D only .txt files and print the text from it into console. Catch appropriative exceptions.
 */