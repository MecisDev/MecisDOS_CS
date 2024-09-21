// See https://aka.ms/new-conso// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, This is a partial port of MecisDOS to the C# Programming Language. Enjoy!");
while (true)
{
    Console.Write("mecisdoscs@root:~$ ");
    string com1 = Console.ReadLine() ?? string.Empty;

    if (com1 == "help")
    {
        Console.WriteLine("Commands: help, about, exit");
    }
    else if (com1 == "exit")
    {
        Console.WriteLine("Exiting...");
        Environment.Exit(0);
    }
    else if (com1 == "about")
    {
        Console.WriteLine("MecisDOS is a DOS-like operating system that is written in C# and is open-source. It is a fun project to rewrite this program from Python to C# but not replace it completly. This DOS Version don't use wide range of commands like the Original Python Version");
        Console.WriteLine("But it has the basic commands.");
    }
    else if (com1 == "clear")
    {
        Console.Clear();
    }
    else if (com1 == "ver")
    {
        Console.WriteLine("MecisDOS on C# Version 1 Build 1");
        Console.WriteLine("C# Version: " + Environment.Version);
    }
    else
    {
        Console.WriteLine("Command not found. Type 'help' for a list of commands.");
    }
}