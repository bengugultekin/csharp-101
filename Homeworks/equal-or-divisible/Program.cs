namespace equal_or_divisible;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Lütfen bir sayı giriniz");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        for(int i=0; i < n; i++)
        {
            Console.WriteLine("Lütfen {0} sayisini giriniz:", i+1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Lütfen bir sayı daha giriniz");
        int m = int.Parse(Console.ReadLine());

        for(int i=0; i<n; i++)
        {
            if(numbers[i] == m || numbers[i] % m == 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }


    }
}
