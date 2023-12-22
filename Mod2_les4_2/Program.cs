namespace modul2_les4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char g = 'g';
            char h = 'h';
            char i = 'i';

            char[] letters = [g, h, i];
            foreach (char letter in letters.Reverse())
            {
                Console.WriteLine(letters);
            }

        }
    }
}
