using ConsoleApp40;

namespace ConsoleApp40
{
    class MilkSong
    {
        public void Sing()
        {
            for (int i = 99; i > 0; i--)
            {
                if (i <= 99 && i != 1)
                {
                    Console.WriteLine($"{i} bottles of milk on the wall,{i} bottles of milk.");
                    Console.WriteLine("Take one down and pass it around,");
                    Console.WriteLine();
                }
                else if (i ==1)
                {
                    Console.WriteLine($"{i} bottle of milk on the wall,{i} bottle of milk.");
                    Console.WriteLine();
                }

                
            }
            
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MilkSong milkSong = new MilkSong(); 
        milkSong.Sing();
    }
}
