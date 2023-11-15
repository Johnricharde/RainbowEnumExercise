using System.Drawing;

public enum rainbow : byte
{
    red,
    orange,
    yellow,
    green,
    blue,
    indigo,
    violet,
}

namespace RainbowEnumExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Here's a rainbow:");
            showRainbow();
        }
        static void showRainbow()
        {
            foreach (var color in Enum.GetValues(typeof(rainbow)))
            {
                Console.WriteLine(color);
            }
        }
    }
}
