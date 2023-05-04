

using ContactList;

//  prv nacin    while (true)
//{
//    insertPhoneBook();
//}


// VTOR nacin
insertPhoneBook();

void insertPhoneBook()
{
    Console.WriteLine("Welcome to Phone Book");

    Console.WriteLine("How many contacts do you want to insert?");

    int brContacts = int.Parse(Console.ReadLine());

    PhoneBook phoneBook = new PhoneBook();

    for (int i = 0; i < brContacts; i++)
    {
        Console.WriteLine("Insert Name");
        var name = Console.ReadLine();

        Console.WriteLine("Insert Surname");
        var surname = Console.ReadLine();

        Console.WriteLine("Insert Address");
        var address = Console.ReadLine();

        Console.WriteLine("How many numbers do you want to insert?");

        int brNumber = int.Parse(Console.ReadLine());
        List<string> phoneNumbers = new List<string>();
        for (int j = 0; j < brNumber; j++)
        {
            Console.WriteLine($"Insert number {j + 1}");

            phoneNumbers.Add(Console.ReadLine());

        }
        Contact contact = new Contact(name, surname, address, phoneNumbers);
        phoneBook.Contacts.Add(contact);

    }
    phoneBook.ToString();
    insertPhoneBook();

}