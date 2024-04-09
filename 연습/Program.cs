
namespace 연습
{


    internal class Program
    {

        static void Main(string[] args)
        {
            int a = (int)3.6f;
            Console.WriteLine(a);
            GiftBoxManager manager = new GiftBoxManager();
            manager.SetInit();
        }


    }

}