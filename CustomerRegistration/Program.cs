using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static List<Client> listClients = new List<Client>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1 - Register Client");
            Console.WriteLine("2 - Display Client");
            Console.WriteLine("3 - Exit");

            Console.WriteLine("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    RegisterClient();
                    break;
                case "2":
                    DisplayClient();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default: Console.WriteLine("Invalid. Try Again!");
                    break;

            }
        }
    }

    static void RegisterClient()
    {
        Client newClient = new Client();

        Console.Write("Name: ");
        newClient.Name = Console.ReadLine();

        Console.Write("Email: ");
        newClient.Email = Console.ReadLine();

        Console.Write("Phones: ");
        newClient.Phones = Console.ReadLine();

        listClients.Add(newClient);

        Console.WriteLine("Client registered successfully!\n");
    }

    static void DisplayClient()
    {
        if (listClients.Count == 0) 
        {
            Console.WriteLine("No registered clients\n");
            return;
        }

        Console.WriteLine("Client List:\n");

        foreach (Client client in listClients)
        {
            Console.WriteLine($"Name: {client.Name}");
            Console.WriteLine($"Email: {client.Email}");
            Console.WriteLine($"Phones: {client.Phones}");
            Console.WriteLine("--------------------------");

        }
    }
}
