
CreateStudent stu1 = new CreateStudent();

stu1.FirstName = "Mohammed";
stu1.LastName = "Almashhor";
stu1.Id = 111;
System.Console.WriteLine(stu1.StudentIfo);

CreateStudent stu2 = new CreateStudent("Ali","Alhadi");
System.Console.WriteLine(stu2.StudentIfo);
CreateStudent stu3 = new CreateStudent(112,"Ali","Alhadi");
System.Console.WriteLine(stu3.StudentIfo);
CreateStudent stu4 = new CreateStudent(113,"Ali","Alhadi");
System.Console.WriteLine(stu4.StudentIfo);

