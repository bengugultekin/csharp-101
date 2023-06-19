namespace reverse_words;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lütfen kelime sayısını giriniz");
        int n = int.Parse(Console.ReadLine());

        string[] words = new string[n];
        for(int i = 0; i<n; i++)
        {
            Console.WriteLine("Lutfen {0} kelimesini giriniz: ", i+1);
            words[i] = Console.ReadLine();
        }

        foreach(var word in words)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
        }
    }
}
