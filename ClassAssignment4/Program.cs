using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Text align centre
            string text = "Welcome to dineo's garden";
            int consoleWidth = Console.WindowWidth;
            int textPadding = (consoleWidth - text.Length) / 2;
            Console.WriteLine(text.PadLeft(textPadding + text.Length));

            Console.WriteLine("==================================================================================");
            Console.WriteLine("==================================================================================");
            flower rose = new flower("Rose Plant", "Rose", "Red", "Spring");
            
            flower sunflower = new flower("Sunflower Plant", "Sunflower", "Yellow", "Summer");
           
            flower daisy = new flower("Daisy Plant", "Daisy", "Pink", "Fall");
            
            
            // Call methods to interact with each flower object

            rose.DisplayFlowerInfo();
            rose.Bloom();

            Console.WriteLine();

            sunflower.DisplayFlowerInfo();
            sunflower.Bloom();
            

            Console.WriteLine();

            daisy.DisplayFlowerInfo();
            daisy.Bloom();
           
        }
    }
}
