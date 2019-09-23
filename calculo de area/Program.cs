using System;

namespace calculo_de_area
{
    class Program
    {
        static void Main(string[] args)
        {
            string forma;
            int area=0;

            Console.WriteLine("Qual a forma desejada");
            forma = Console.ReadLine();

            switch (forma)
            {
                
                case "quadrado":
                area = 2 * 2;
                Console.WriteLine("2 CM de area " + area + "cm2"); 

            }
            

        

            


        }
    }
}
