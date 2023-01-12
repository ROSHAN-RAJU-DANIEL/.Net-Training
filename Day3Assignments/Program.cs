AddressBook addressBook = new AddressBook();
{
    Console.WriteLine("Enter no of contacts to be added");
    int n = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Enter details to add to contact");
        addressBook.AddContact();
    }

       // ListContacts
        addressBook.printContacts();

       // sort contacts
        addressBook.SortContacts();
       Console.WriteLine("Contacts After Sorting FirstName");
       addressBook.printContacts();


    // remove contacts
    addressBook.RemoveContact();

}
