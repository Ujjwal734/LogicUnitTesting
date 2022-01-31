// See https://aka.ms/new-console-template for more information
using LogicUnitTesting;
Console.WriteLine("Hello, Welcome to Nunit testing progamming");
Console.WriteLine("1. Vending Machine");
int option = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Press  's'   to start programe and 'n' to stop progrme");
char ch = Convert.ToChar(Console.ReadLine()); 
while(ch != 'n')
{
    switch(option)
    {
        case 1:
            Vending vending = new Vending();
            Console.WriteLine("Enter a amount how much you want a change :-");
            vending.Machine();
            break;
    }
}
