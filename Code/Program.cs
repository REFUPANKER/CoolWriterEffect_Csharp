using System.Threading.Tasks;
namespace CoolWriteLineTest1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            WriteLine("New Project", 2, 5);
            WriteLine("Turkiye/Karabuk", 2, 5);
            WriteLine("11.00 Rainy", 2, 5);
            WriteLine("Share on social media",3,5);
        }
        static void cwl(Object msg)
        {
            System.Console.WriteLine(msg);
        }
        static void cw(Object msg)
        {
            System.Console.Write(msg);
        }
        static void WriteLine(string msg, int charDelay, int nextCharDelay)
        {
            Random rnd = new Random();
            for (int i = 0; i < msg.Length; i++)
            {
                for (int j = 0; j < charDelay; j++)
                {
                    cw(((char)rnd.Next(65, 92)));
                    Thread.Sleep(nextCharDelay);
                    cw("\b");
                }
                cw(msg[i]);
            }
            cwl("");
        }
    }
}
