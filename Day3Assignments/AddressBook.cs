
public class AddressBook
{
    private List<Contact> contactList;

    public AddressBook()
    {
        contactList = new List<Contact>();
    }
    public void AddContact()
    {
        string firstName = string.Empty;
        string lastName = string.Empty;
        string email = string.Empty;
        string phone = string.Empty;
        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine();
        Console.Write("Please enter your email: ");
        email = Console.ReadLine();
        Console.Write("Please enter your phone number:");
        phone = Console.ReadLine();
        contactList.Add(new Contact(firstName, lastName, phone, email));
        Console.Write("Contact saved Successfully");
    }
    public void RemoveContact()
    {
        Console.WriteLine("enter number of contacts to delete");
        int m = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<m;i++)
        {
            Console.WriteLine("removed" + contactList[i]);
            contactList.Remove(contactList[i]);

        }
    }
    public void SortContacts()
    {

        contactList.Sort((x, y) => string.Compare(x.firstName, y.firstName));
    }
    public void printContacts()
    {
        Console.WriteLine(" List of all Contacts: ");
        foreach (var contact in contactList)
        {
            Console.WriteLine($"{contact}");
        }

    }
}