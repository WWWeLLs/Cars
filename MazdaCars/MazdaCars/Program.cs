using System;

namespace MazdaCars
{       class Car


    //PROPERTIES
    {
        public string name6;
        public string nameC;

        public int year6;
        public int yearC;

        public string color6;
        public string colorC;

        public string named6;
        public string namedC;

        //CONSTRUCTOR
        public Car()
        {
            name6 = "Mazda6GT";
            nameC = "MazdaCX9";

            year6 = 2016;
            yearC = 2019;

            color6 = "Solid Red";
            color6 = "Chocolate";

            named6 = "Black Rose";
            namedC = "Black Butta";

        }
  
    }
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("ZOOM ZOOM");
            Console.WriteLine(" WHAT DRIVES YOU");


            Car mazda = new Car();
            Console.WriteLine(mazda.name6);
            Console.WriteLine(mazda.color6);
            Console.WriteLine(mazda.year6);
            Console.WriteLine(mazda.named6);

            Console.WriteLine(mazda.nameC);
            Console.WriteLine(mazda.colorC);
            Console.WriteLine(mazda.yearC);
            Console.WriteLine(mazda.nameC);
        }

            


           
        
          


}   } 