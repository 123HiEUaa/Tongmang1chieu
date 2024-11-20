internal class Program
{
    private static void Main(string[] args)
    {
       int[ ] myInt = { 1, 2, 3, 4, 5, 6 , 7, 8};
       int sum = 0;
       for (int i = 0; i < myInt.Length; i++)
       {
            sum+=myInt[i];
       } 
       Console.WriteLine("Gia tri la {0}", sum);
    }
}