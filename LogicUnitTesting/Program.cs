﻿// See https://aka.ms/new-console-template for more information
using LogicUnitTesting;
Console.WriteLine("Hello, Welcome to Nunit testing progamming");
Console.WriteLine("1. Vending Machine \n2. Temperatures Conversion \n3. Finding SquareRoot");
int option = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Press  's'   to start programe and 'n' to stop progrme");
char ch = Convert.ToChar(Console.ReadLine()); 
while(ch != 'n')
{
    switch (option)
    {
        case 1:
            Vending vending = new Vending();
            Console.WriteLine("Enter a amount how much you want a change :-");
            vending.Machine();
            break;
        case 2:
            Temperatures temperatures = new Temperatures();
            Console.WriteLine("Enter a degree in degree celsicus :- ");
            temperatures.degreeC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a degree in degree Faherenhite :- ");
            temperatures.faherenhite = Convert.ToInt32(Console.ReadLine());
            temperatures.Celcius();
            temperatures.Faheren();
            break;
        case 3:
            Sqroot sqroot = new Sqroot();
            double num;
            Console.WriteLine("Enter a number for finding square root :- ");
            num = Convert.ToDouble(Console.ReadLine());
            double num2 = 0.00001;
            sqroot.squareRoot(num, num2);
            break;
    }
}
