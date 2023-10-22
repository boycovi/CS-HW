using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> contacts = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select Action:");
            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Remove contact");
            Console.WriteLine("3. Search contact via name");
            Console.WriteLine("4. Display all contacts");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddContact();
                    break;
                case "2":
                    RemoveContact();
                    break;
                case "3":
                    SearchContact();
                    break;
                case "4":
                    DisplayAllContacts();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Incorrect input.");
                    break;
            }
        }
    }

    static void AddContact()
    {
        Console.WriteLine("Enter contact's name:");
        string name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            Console.WriteLine("A contact with that name already exists.");
        }
        else
        {
            Console.WriteLine("Enter phone number:");
            string phoneNumber = Console.ReadLine();
            contacts.Add(name, phoneNumber);
            Console.WriteLine("Contact successfully added");
        }
    }

    static void RemoveContact()
    {
        Console.WriteLine("Enter contact name to delete:");
        string name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            contacts.Remove(name);
            Console.WriteLine("The contact has been deleted");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    static void SearchContact()
    {
        Console.WriteLine("Enter contact name to search:");
        string name = Console.ReadLine();

        if (contacts.ContainsKey(name))
        {
            Console.WriteLine($"{name}'s phone number : {contacts[name]}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }

    static void DisplayAllContacts()
    {
        if (contacts.Count > 0)
        {
            Console.WriteLine("All contacts list:");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Key}, Phone number: {contact.Value}");
            }
        }
        else
        {
            Console.WriteLine("Contact number list is empty.");
        }
    }
}