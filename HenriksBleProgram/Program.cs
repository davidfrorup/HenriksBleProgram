namespace HenriksBleProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lokal variabel. Declared, added a value
            int timeToChangeDiaper = 10;

            // Console.WriteLine("Hello, World!");

            //Calling method with parameter
             DiaperChange(timeToChangeDiaper);

            //  HowManyCockroachesDidTheDragonEat();

            cmTilFoot();
        }

        // Altid brug PascalCasing for metoder, classes og properties
        // BRUG ENGELSK!
        private static void DiaperChange(int dc)
        {
            Console.WriteLine("Det er tid til bleskift om: " + dc + " minutter");
            Console.WriteLine($"Det er tid til bleskift om:   {dc}  minutter");
            Console.WriteLine("Det er tid til bleskift om: {0}  minutter", dc);
        }

        static int HowManyCockroachesDidTheDragonEat()
        {
            //string str;

            // null check
            //if (str == null) Console.WriteLine("str is null");
            //else Console.ReadLine();

            // Do {get input} while input is not an int

            

            int i;

            do  Console.WriteLine("How many?!: ");
            while (!int.TryParse(Console.ReadLine(), out i));
            if (10>5 && 10<100)
                return i;
            //int i = Convert.ToInt32(str);



        }

        static void cmTilFoot()
        {
            double cm;
            double foot;

            Console.WriteLine("Velkommen til 'cm til foot' omregneren");

            while (true)
            {
                
                Console.WriteLine("Indtast venligst hvor mange cm'er der skal omregnes.");
               // cm = Convert.ToDouble(Console.ReadLine());
                string input = Console.ReadLine();

                if (double.TryParse(input, out cm))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Fejl, prøv igen");

                }
            }

            foot = cm * 0.032808399;
            string result = foot.ToString("0.##");
            Console.WriteLine(cm + "cm bliver til: " + result + " feet");

            Console.ReadKey();
            Console.Clear();

            cmTilFoot();

        }

    }
}