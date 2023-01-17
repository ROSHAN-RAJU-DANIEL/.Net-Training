// Encapsulation

class Person
{

    // default constructor
    public Person(string firstName, string lastname, int age, double salary)
    {
        FirstName = firstName;
        LastName = lastname;
        Age = age;
        _salary = salary;
    }

    // properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Fields
    private double _salary;

    // Methods
    public void SetSalary(double salary)
    {
        _salary = salary;
    }
    public double GetSalary()
    {
        return _salary;
    }
    public string GetFullName()
    {
        return FirstName + " " + LastName;
    }
    public string GetFullName(string middleName)
    {
        return FirstName + " " +  middleName + " " + LastName;
    }
}
