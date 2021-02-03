using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_15_OOP___Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const float regdelivery1 = 7.15f, standard1 = 5.00f, standard2 = 2.20f, recordeddelivery = 6.20f, xregdelivery1 = 2.00f, xstandard1 = 0.50f, xstandard2 = 0.20f, xrecordeddelivery = 1.00f;
            float userweight = 0, realweight = 0;
            string CustomerName;

            //showing the prices
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Type of service  *Basic charge for 1KG (£)* Extra charge per unit weight (£) *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*Registered        *         7.15           *               2.00               *");
            Console.WriteLine("*delivery 1st Class*                        *                                  *");
            Console.WriteLine("*Standard          *         5.00           *               0.50               *");
            Console.WriteLine("*1st Class         *                        *                                  *");
            Console.WriteLine("*Standard          *         2.20           *               0.20               *");
            Console.WriteLine("*2nd Class         *                        *                                  *");
            Console.WriteLine("*48 hour           *         6.20           *               1.00               *");
            Console.WriteLine("*recorded delivery *                        *                                  *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("*Press enter to continue with your delivery quote...                           *");
            Console.WriteLine("********************************************************************************");
            Console.ReadKey();

            //Enter customer details
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Please enter your name");
            CustomerName = Console.ReadLine();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Please enter your Email");
            Console.ReadLine();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("Please enter your mobile number");
            Console.ReadLine();

            //Asking for the weight of the parcel
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("What is the weight of your parcel in KG?");
            realweight = float.Parse(Console.ReadLine());

            //Customers name message
            Console.WriteLine("Here is your personal delivery quote " + CustomerName);
            
            //IF statements to work out the prices for each delivery type

            //registered delivery first class if statement
            if (realweight <= 1) {
                Console.WriteLine("The price for send your parcel through registered delivery 1st class is £" + regdelivery1);
            } else if (realweight > 1) {
                userweight = realweight - 1;
                float price = (userweight * xregdelivery1 + regdelivery1);
                Console.WriteLine("The price for send your parcel through registered delivery 1st class is £" + price);
            }
            
            //registered standard first class if statement
            if (realweight <= 1)
            {
                Console.WriteLine("The price for send your parcel through standard 1st class is £" + standard1);
            }
            else if (realweight > 1)
            {
                userweight = realweight - 1;
                float price = (userweight * xstandard1 + standard1);
                Console.WriteLine("The price for send your parcel through standard 1st class is £" + price);
            }

            //stantard second class if statement
            if (realweight <= 1)
            {
                Console.WriteLine("The price for send your parcel through standard 2nd class is £" + standard2);
            }
            else if (realweight > 1)
            {
                userweight = realweight - 1;
                float price = (userweight * xstandard2 + standard2);
                Console.WriteLine("The price for send your parcel through standard 2nd class is £" + price);
            }

            //48 hour recorded delivery if statement
            if (realweight <= 1)
            {
                Console.WriteLine("The price for send your parcel through 48 hour delivery is £" + recordeddelivery);
            }
            else if (realweight > 1)
            {
                userweight = realweight - 1;
                float price = (userweight * xrecordeddelivery + recordeddelivery);
                Console.WriteLine("The price for send your parcel through 48 hour delivery is £" + price);
            }
            Console.ReadKey();
        }
    }
}
