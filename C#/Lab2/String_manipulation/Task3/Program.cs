



namespace Task3
{
    class Program
    {
        static void Main()
        {

            var vowels = new Dictionary<char, bool>()
            {
                {'a', true},
                {'i', true},
                {'o', true},
                {'u', true},
                {'e', true},
                {'A', true},
                {'I', true},
                {'O', true},
                {'U', true},
                {'E', true}
            };

            Console.Write("Enter A Sentence : ");
            string sentence = Console.ReadLine();

            int vowelCount = 0;

            foreach (char character in sentence)
                if (vowels.ContainsKey(character))
                    vowelCount++;

            System.Console.WriteLine($"Vowels Count : {vowelCount}");
        }
    }
}