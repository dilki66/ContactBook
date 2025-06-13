class Program
{
    static void Main(string[] args)
    {
        // Create a dictionary to store contact name and email
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n--- Contact Book Menu ---");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. View All Contacts");
            Console.WriteLine("3. Search Contact");
            Console.WriteLine("4. Update Contact");
            Console.WriteLine("5. Delete Contact");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter email: ");
                    string email = Console.ReadLine();

                    if (!contacts.ContainsKey(name))
                    {
                        contacts.Add(name, email);
                        Console.WriteLine("Contact added.");
                    }
                    else
                    {
                        Console.WriteLine("Contact already exists.");
                    }
                    break;

                case 2:
                    Console.WriteLine("--- All Contacts ---");
                    foreach (var contact in contacts)
                    {
                        Console.WriteLine($"Name:{contact.Key} , Email :{contact.Value}");
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter the name to search");
                    string searchName = Console.ReadLine();

                    if (contacts.TryGetValue(searchName, out string foundemail))
                    {
                        Console.WriteLine($"Email: {foundemail}");
                    }

                    else
                    {
                        Console.WriteLine("Name Not Found");
                    }
                    break;

                case 4:
                    Console.WriteLine("Enter the name to update email");
                    string updateName = Console.ReadLine();

                    if (contacts.ContainsKey(updateName))
                    {
                        Console.WriteLine("Enter new email");
                        string newEmail = Console.ReadLine();
                        contacts[updateName] = newEmail;
                        Console.WriteLine("Email updated");
                    }
                    else
                    {
                        Console.WriteLine("contact not found");
                    }
                    break;

                case 5:
                    Console.WriteLine("Enter the name to delete");
                    string deleteName = Console.ReadLine();

                    if (contacts.Remove(deleteName))
                    {
                        Console.WriteLine("Contact deleted");
                    }

                    else
                    {
                        Console.WriteLine("Contact not found");
                    }
                    break;

                case 6:
                    exit = true;
                    Console.WriteLine("Exiting Contact Book");
                    break;

                default:
                    Console.WriteLine("Invalid option.. Try again..!!");
                    break;
            }
        }
    }
}