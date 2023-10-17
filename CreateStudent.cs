public class CreateStudent{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string StudentIfo { get; private set; }
    public DateTime Date { get; private set; }
    

    public CreateStudent()
    {
        Date = DateTime.Now;
        StudentIfo = string.Concat("Id: "+Id +"\nName: "+FirstName + LastName+"\nDate: "+Date);

    }

    public CreateStudent(string firstName, string lastName) :this()
    {
        FirstName = firstName;
        LastName = lastName;
    }
    
    public CreateStudent(int Id,string firstName, string lastName) :this(firstName,lastName)
    {
        this.Id = Id;
    }
}