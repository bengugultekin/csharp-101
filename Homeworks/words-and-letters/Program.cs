namespace words_and_letters;

class Program
{
    static void Main(string[] args)
    {
        int word = 1;
        int letter = 0;
        Console.WriteLine("Lütfen bir cümle yazın");
        string sentence = Console.ReadLine();

        
        for(int i = 0; i<sentence.Length; i++)
        {
            if(sentence[i] != ' ')
            {
                letter++;
            }
            else if(sentence[i] == ' ')
            {
                word++;
            }
        }

        Console.WriteLine("Cümledeki harf sayısı:" + letter);
        Console.WriteLine("Cümledeki kelime sayısı:" + word);
        
    }
}
