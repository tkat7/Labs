using System;

public class Program
{
    public static void Main(string[] args)
    {
        Boolean cont = true;
        while (cont == true)
        {
            Console.WriteLine("What is the name of your room?");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the width of the room in inches");
            Boolean numberW = false;
            double nW;
            string inputW = Console.ReadLine();
            numberW = double.TryParse(inputW, out nW);
            while (numberW == false)
            {
                Console.WriteLine("That is not a valid number, Please enter a valid width in inches");
                inputW = Console.ReadLine();
                numberW = double.TryParse(inputW, out nW);
            }
            double width = double.Parse(inputW);

            double nL;
            Console.WriteLine("Please enter the length of the room in inches");
            Boolean numberL = false;
            string inputL = Console.ReadLine();
            numberL = double.TryParse(inputL, out nL);
            while (numberL == false)
            {
                Console.WriteLine("That is not a valid number, Please enter a valid length in inches");
                inputL = Console.ReadLine();
                numberL = double.TryParse(inputL, out nL);
            }
            double length = double.Parse(inputL);

            double nH;
            Console.WriteLine("Please enter the height of the room in inches");
            Boolean numberH = false;
            string inputH = Console.ReadLine();
            numberH = double.TryParse(inputH, out nH);
            while (numberH == false)
            {
                Console.WriteLine("That is not a valid number, Please enter a valid height in inches");
                inputH = Console.ReadLine();
                numberH = double.TryParse(inputH, out nH);
            }
            double height = double.Parse(inputH);



            double area = length * width;
            double perim = (length * 2) + (width * 2);
            double volume = length * width * height;
            Console.WriteLine("The Measurements for " + name + " are:");
            Console.WriteLine("Area: " + area + " inches.");
            Console.WriteLine("Perimeter: " + perim + " inches.");
            Console.WriteLine("Volume: " + volume + " inches.");

            Console.WriteLine("Do you want have more rooms to measure? Type yes to continue!");
            String read = Console.ReadLine();
            if (read == "Yes" || read == "yes")
            {
                cont = true;
            }
            else
            {
                cont = false;
                Console.WriteLine("Thank you for using my program");
            }
        }
    }
}