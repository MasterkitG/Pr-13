namespace Pr_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Текст");
            string[] words = Console.ReadLine().Split(" ");
            int povtor = 0;
            string text = "Повторяющиеся слова: ";
            string[] duplicates = new string[1];
            int r = 0;
            for (int i = 0; i < words.Length; i++)
            {
                povtor = 0;
                for(int j = 0; j < words.Length; j++)
                {
                    if (words[j].ToLower() == words[i].ToLower()) { povtor++; }
                }
                if (povtor > 1 && duplicates.Contains(words[i].ToLower())!=true) { if (r == 0) { duplicates[r] = words[i].ToLower(); } else { Array.Resize(ref duplicates, r+1); duplicates[r] = words[i].ToLower(); } r++; } 
            }
            foreach (string duplicate in duplicates) { if (duplicate == duplicates[duplicates.Count()-1]) { text += duplicate; } else { text += duplicate + ", "; } }
            if (string.IsNullOrEmpty(duplicates[0])) { Console.WriteLine("В предложение нет повторяющихся слов"); }
            else {Console.WriteLine(text); }
            
            
        }
    }
}
