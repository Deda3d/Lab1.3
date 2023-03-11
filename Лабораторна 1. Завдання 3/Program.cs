class Program
{
    static void Main(string[] args)
    {
        int L = 5;
        string[] A = { "ABCDE", "WXYZA", "MNOPQ"};

        string result = A.Where(x => x.Length == L).OrderByDescending(x => x).FirstOrDefault();

        Console.WriteLine(result);
    }
}