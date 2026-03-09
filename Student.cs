using System;

class Student
{
    private string firstName;
    private string lastName;
    private string patronymic;

    public Student(string lastName, string firstName, string patronymic)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.patronymic = patronymic;
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; } 
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Patronymic
    {
        get { return patronymic; }
        set { patronymic = value; }
    }
    
    public string GetInformation()
    {
        return LastName + " " + FirstName + " " + Patronymic;
    }
}