using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG655_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j; //Counter
            double[][] sales; //Jagged Array
            double totalsales = 0;
            Console.Write("Number of salespeople? ==>");
            int salespeople = Convert.ToInt32(Console.ReadLine());
            double[] subtotal = new double[salespeople];
            sales = new double[salespeople][];
            string[] salesname = new string[salespeople];
            string maxnamesales = null;
            double? maxsubtotal = null;
            //double[] maxsinglesale = new double[salespeople];
            double maxsinglesale = 0.0;

            for (i = 0; i < salespeople; i++)
            {
                Console.Write("Salesperson Name #" + (i + 1) + " ==>");
                salesname[i] = Console.ReadLine();
                Console.Write("Number of cars sold by " + salesname[i] + " ==>");
                int carssold = Convert.ToInt32(Console.ReadLine());
                sales[i] = new double[carssold];

                for (j = 0; j < carssold; j++)
                {
                    Console.WriteLine("Sale price for car #" + (j + 1) + " ==>");
                    sales[i][j] = Convert.ToDouble(Console.ReadLine());
                    subtotal[i] += sales[i][j];
                    totalsales += sales[i][j];
                }
            }

            Console.Clear();

            Console.WriteLine("╔══════════════════╦══════════════════╦══════════════════╦══════════════════╗");
            Console.WriteLine("║                  ║     Name         ║   Total Sales    ║    Commision     ║");
            Console.WriteLine("╠══════════════════╬══════════════════╬══════════════════╬══════════════════╣");

            for (i = 0; i < salespeople; i++)
            {
                j = 0;
                //Console.WriteLine("{0,-16}{1,-16}{2,-16}{3,-16}", "║", "Salesman #" + (i + 1) +   "║   " + salesname[i] + " ", "     ║    $" +   subtotal[i] + "", "        ║     $" + (subtotal[i]) * 0.05 + "        ║");
                Console.WriteLine("{0,0}{1,0}{2,0}{3,8}{4,12}{5,8}{6,11}{7,8}{8,13}{9,5}", "║", "Salesman #", (i + 1), "║", salesname[i], "║$", subtotal[i], "║$", (subtotal[i]) * 0.05, "║");
                j++;
            }
            Console.WriteLine("╚══════════════════╩══════════════════╩══════════════════╩══════════════════╝");
            Console.WriteLine("Total sales of all " + i + " Salespeople: $" + totalsales + " ");
            for (i = 0; i < salesname.Length; i++)  //Counter to count up to all the values in the salesname array
            {
                for (j = 0; j < subtotal.Length; j++)   //Counter to count up to all the values in the subtotal array
                {                                                    //Need to check if at this point, the subtotal max value is present
                    maxsubtotal = subtotal.Max();   //Assign the max value of the array to a variable
                }
                if (maxsubtotal.HasValue == true)      //Check if the new variable is not empty
                {
                    if (maxsubtotal == subtotal.Max())
                    {
                        maxnamesales = salesname[i];    //Get the name of the person at this point which has the max subtotal
                    }
                }

            }
            Console.WriteLine("Highest Total sales of $" + maxsubtotal + " made by " + maxnamesales);

            for (i = 0; i < salesname.Length; i++)  //Counter to count up to all the values in the salesname array
            {
                foreach (double[] element in sales)
                {
                    foreach (double array in element)
                    {
                        //Assign the max value of the array to a variable
                        if (maxsinglesale < array)
                        {
                            maxsinglesale = array;
                        }

                        if (maxsinglesale > array)
                        {
                            maxnamesales = salesname[i];    //Get the name of the person at this point which has the max single sale
                        }
                    }
                }
                /* for (j = 0; j < sales.Length; j++) //Counter to count up to all the values in the sales array
                {
                    maxsinglesale = sales.Max();    //Assign the max value of the array to a variable
                    maxnamesales = salesname[i];    //Get the name of the person at this point which has the max single sale
                } */
            }
            Console.WriteLine(maxnamesales + " made the highest single sale of $ " + maxsinglesale);

            Console.WriteLine("Press any key to continue...");

            Console.ReadLine();

            Application.Run(new Form1(salesname, subtotal, salespeople));
        }
    }
}