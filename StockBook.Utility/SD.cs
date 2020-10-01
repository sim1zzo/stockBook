using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockBook.Utility
{
    public static class SD
    {

        public const string Role_User_Indi = "Individual Customer";
        public const string Role_User_Comp = "Company Customer";
        public const string Role_Admin = "Admin"; //can manage the content of the web site 
        public const string Role_Employee = "Employee";//able to change the status of the packages payment and so on.

        public const string ssShoppingCart = "Shopping Cart Session";


        public static double GetPriceBasedOnQuantity(double quantity, double price, double price50, double price100)
        {
            if (quantity < 50)
            {
                return price;
            }
            else
            {
                if (quantity < 100)
                {
                    return price50;
                }
                return price100;
            }
        }


        public static string ConvertToRawHtml(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;
            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    break;
                }

                if (!inside)
                {
                    array[arrayIndex++] = let;

                }

            }
            return new string(array, 0, arrayIndex);

        }
    }
}
