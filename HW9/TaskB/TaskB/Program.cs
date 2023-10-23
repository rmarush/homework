namespace TaskB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] textFile = File.ReadAllLines(@"D:\program.txt");
            Console.WriteLine("--- TASK 1 ---");
            CountSymbolsInLine(textFile);
            Console.WriteLine("--- TASK 2 ---");
            FindMaxAndMinLine(textFile);
            Console.WriteLine("--- TASK 3 ---");
            FindVarInLine(textFile);
        }
        static public void CountSymbolsInLine(string[] textFile)
        {
            foreach (string line in textFile)
            {
                int count = line.Count();
                Console.Write(line + " == " + count + " symbols\n");
            }
        }
        static public void FindMaxAndMinLine(string[] textFile)
        {
            string shortestLine = textFile.Where(line => !string.IsNullOrEmpty(line))
                                          .OrderBy(x => x.Length)
                                          .First();
            string longestLine = textFile.OrderBy(x => x.Length)
                                         .Last();
            Console.WriteLine($"LongestLine =>\n{longestLine}\n" +
                              $"ShortestLine =>\n{shortestLine}");
        }
        static public void FindVarInLine(string[] textFile)
        {
            IEnumerable<string> lineHasVar = from line in textFile
                                             where line.Contains("var")
                                             select line;
            foreach (string line in lineHasVar)
            {
                Console.WriteLine(line);
            }
        }
    }
}

/*
 * B) Create Console Application project.
 * Prepare txt file with a lot of text inside (for example take you .cs file from previos homework)
 * Read all lines of text from file into array of strings.
 * Each array item contains one line from file.
 * Complete next tasks:
 * 1) Count and write the number of symbols in every line.
 * 2) Find the longest and the shortest line. 
 * 3) Find and write only lines, which consist of word "var"
 */