string password = "root";
bool access = false;

while (!access)
{
    Console.WriteLine("Enter a password: ");
    string tryPassword = Console.ReadLine();
    if (tryPassword == password)
    {
        Console.WriteLine("Access Granted");
        Thread.Sleep(1000);
        access = true;
        Environment.Exit(0);
    }
    else Console.WriteLine("Wrong Password");
}