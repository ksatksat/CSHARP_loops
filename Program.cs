using System;
class Program{
    static void Main(string[] args)
    {
        int i = 0;
        // пока (итератор не равен ста) { итератор увеличить на один }
        while(i != 0)
        {
            Hlopat();
            i++;
        }
        Console.WriteLine("==================================================================");
        
        do
        {
            Console.WriteLine("luboe msg");
        }while(i != 0);
        //=================================================
        Console.Write("Please create your password: ");
        string password = Console.ReadLine();
        Console.Write("Please enter password: ");
        string attempt = Console.ReadLine();
        if (password == attempt)
        {
            Console.WriteLine("Welcome!");
        }
        else
        {
            Console.WriteLine("Access denied!");
        }
        //=================================================
        Console.WriteLine("==================================================================");
        //string name = "maxat";
        char[] name_2 = {'m', 'a', 'x', 'a', 't'};
        //для каждого (символа ч внутри массива name_2)
        int[] ints = {1,2,3,4,5,6,7,8,9,10};
        string[] names = {"Vasia", "Petia", "Vania", "Fedor", "Boris"};
        //для каждого символа в массиве символов name_2
        foreach (char ch in name_2)
        {
            Console.WriteLine(ch);
        }

        foreach(int celoeChislo in ints)
        {
            Console.WriteLine(celoeChislo);
        }
        for(int j = 0; j < 10; j += 3)
        {
            Console.WriteLine("Rabotaet cikl FOR()");
        }
        for(int k = 0; k < 10; k += 2)
        {
            Console.WriteLine("All even numbers from 0 to 10: " + k);
        }
        for (int k = 0; k < 10; k++)
        {
            if(k % 2 == 1)
            {
                Console.WriteLine("All odd numbers from 0 to 10: " + k);
            }
        }
    }
    static public void Hlopat()
    {
        Console.Write(" Hlopau ");
    }
}