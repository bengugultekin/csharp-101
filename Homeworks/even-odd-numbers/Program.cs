namespace even_odd_numbers;

class Program
{
    static void Main(string[] args)
    {
        // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
        // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
        // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
        Console.WriteLine("Bir sayi giriniz: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Lutfen {0} sayisini giriniz: ", i+1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        foreach (var number in numbers)
        {
            if(number % 2 == 0)
            {
                Console.WriteLine(number);
            }
        }

    }
}
