using brrt_brrt_4;
using System;

class Program
{
    public static void Main()
    {
        Class myitm = new Class();
        myitm.item = "Item: Ariel";
        Console.WriteLine(myitm.item);

        Console.WriteLine("Enter Quantity: ");
        int quantity = Convert.ToInt16(Console.ReadLine());

        Class myunit = new Class();
        myunit.unit = "Unit: Sachet";
        Console.WriteLine(myunit.unit);

        Class prc = new Class();
        prc.Price = 7.50;
        Console.WriteLine("Price:" +prc.Price);

        Console.WriteLine("Amount:" + quantity * prc.Price);



    }
       
        
}