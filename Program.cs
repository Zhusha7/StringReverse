namespace StringReverse
{
    internal class Program
    {
        static string? ReverseString(string? s)
        {
            if (string.IsNullOrEmpty(s))
                return s;
            char[] temp = s.ToCharArray();
            for (int i = 0; i < temp.Length/2; i++)
            {
                (temp[i], temp[^(i+1)]) = (temp[^(i+1)], temp[i]);
            }
            return new string(temp);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseString(Console.ReadLine()));
        }
    }
}