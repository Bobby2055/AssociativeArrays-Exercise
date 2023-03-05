namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> letters = new Dictionary<char, int>();

            string input = Console.ReadLine();

            foreach (char currentChar in input)
            {
                if (currentChar == ' ')
                {
                    continue;
                }

                if(!letters.ContainsKey(currentChar))
                {
                    letters[currentChar] = 0;
                }
                
                letters[currentChar]++;
            }
            foreach (var kvp in letters)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }

        }
    }
}