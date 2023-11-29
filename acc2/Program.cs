using System;
using System.Diagnostics;

class Program
{

    /*String[] prod = { "Avocado", "Broccoli", "Corn", "Dragon Fruit", "Eggplant", "Fries" };
    int[] price = { 55, 10, 32, 12, 22, 18 };
    String[] desc = { "Lots of Vitamins", "Healthy", "Yellow", "Antioxidants", "A Fruit", "Cheesy" };
    int[] qty = { 252, 101, 123, 300, 115, 188 };*/

    static void Main(string[] args)
    {

        String[] prod = { "Avocado", "Broccoli", "Corn", "Dragon Fruit", "Eggplant", "Fries" };
        int[] price = { 55, 10, 32, 12, 22, 18 };
        String[] desc = { "Lots of Vitamins", "Healthy", "Yellow", "Antioxidants", "A Fruit", "Cheesy" };
        int[] qty = { 252, 101, 123, 300, 115, 188 };

        bool loop = true;
        while (loop)
        {

            Console.WriteLine("Choose either to sort Price or Quantity");
            Console.WriteLine("1. Price");
            Console.WriteLine("2. Quantity");
            Console.Write("Enter your Choice: ");
            int choice1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose either Ascending or Descending");
            Console.WriteLine("1. Ascending");
            Console.WriteLine("2. Descending");
            Console.Write("Enter your Choice: ");
            int choice2 = Convert.ToInt32(Console.ReadLine());

            if (choice1 == 1)
            {
                if (choice2 == 1)
                {
                    priceasc(price);
                }
                else
                {
                    pricedes(price);
                }
            }
            else
            {
                if (choice2 == 1)
                {
                    qtyasc(qty);
                }
                else
                {
                    qtydes(qty);
                }
            }

            Console.WriteLine("Sorted Products");
            for (int i = 0; i < price.Length; i++)
            {
                Console.WriteLine($"Product: {prod[i]}, Price: {price[i]}, Description: {desc[i]}, Quantity: {qty[i]}");
            }


            Console.Write("Sort Again? (Y/N): ");
            String choice3 = Console.ReadLine();
            if (choice3.ToUpper() != "Y")
            {
                loop = false;
            }
        }

    }

    static void priceasc(int[] price)
    {

        for (int i = 0; i < price.Length - 1; i++)
        {

            for (int j = i + 1; j < price.Length; j++)
            {

                if (price[i] > price[j])
                {

                    int temp;
                    temp = price[i];
                    price[i] = price[j];
                    price[j] = temp;

                }

            }

        }

    }

    static void pricedes(int[] price)
    {

        for (int i = 0; i < price.Length - 1; i++)
        {

            for (int j = i + 1; j < price.Length; j++)
            {

                if (price[i] < price[j])
                {

                    int temp;
                    temp = price[i];
                    price[i] = price[j];
                    price[j] = temp;

                }

            }

        }

    }

    static void qtyasc(int[] qty)
    {

        for (int i = 0; i < qty.Length - 1; i++)
        {

            for (int j = i + 1; j < qty.Length; j++)
            {

                if (qty[i] > qty[j])
                {

                    int temp;
                    temp = qty[i];
                    qty[i] = qty[j];
                    qty[j] = temp;

                }

            }

        }

    }

    static void qtydes(int[] qty)
    {

        for (int i = 0; i < qty.Length - 1; i++)
        {

            for (int j = i + 1; j < qty.Length; j++)
            {

                if (qty[i] < qty[j])
                {

                    int temp;
                    temp = qty[i];
                    qty[i] = qty[j];
                    qty[j] = temp;

                }

            }

        }

    }
}
