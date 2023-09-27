// See https://aka.ms/new-console-template for more information
while (true)
{
    Console.WriteLine("Welcome to todist App");
    Console.WriteLine("Select an option below");
    Console.WriteLine("a.view list");
    Console.WriteLine("b.update list");
    Console.WriteLine("c.create new list");
    Console.WriteLine("x.exit");
    Console.WriteLine("Option: ");
    char userchoice = Convert.ToChar(Console.ReadLine().ToLower());
    switch (userchoice)
    {
        case 'a':
            break;
        case 'b':
            break;
        case 'c':
            break;
        case 'x':
            Console.WriteLine("Goodbye. Press enter .....");
            Console.ReadLine();
            return;
        default:
            Console.WriteLine("Invalid parameter");
            break;

    }

}