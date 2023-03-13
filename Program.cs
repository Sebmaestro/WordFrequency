namespace WordFrequency
{
    /// <summary>
    /// Sebastian Arledal
    /// CGI codetask
    /// 13/03/2023
    /// 
    /// Simple program to receive a textfile and save the 10 most occurred words from that file and print how many times each word appeared
    /// 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            WordCalculator wc = new WordCalculator();
            wc.CalculateWords();
        }

        
    }
}