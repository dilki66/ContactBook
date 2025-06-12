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
            }
        }
    }
}