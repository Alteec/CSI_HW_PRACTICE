using System.Diagnostics.Metrics;

namespace Practice14
{
    class Practice14
    {

        static Dictionary<string, int> Counter(string text)
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();

            text = text.Replace(".", string.Empty);
            text = text.Replace(",", string.Empty);
            string[] words = text.ToLower().Split(' ');

            foreach (string word in words)
            {
                if (counter.ContainsKey(word))
                {
                    counter[word] += 1;
                    continue;
                }
                counter[word] = 1;
            }

            return counter;

        }

        static void DictAsTable(Dictionary<string, int> dict)
        {
            string line = new string('-', 20);
            Console.WriteLine(line);
            foreach (KeyValuePair<string, int> word in dict)
            {
                Console.WriteLine($"|{word.Key,-10}|{word.Value,-7}|");
                Console.WriteLine(line);
            }

        }

        static void Main(string[] args)
        {
            string a = @"Вот дом, Который построил Джек. А это пшеница, Кото­рая в темном чулане хранится В доме, Который построил Джек. А это веселая птица­ синица, Которая часто вору­ет пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";
            var dict=Counter(a);
            DictAsTable(dict);
        }
    }
}