class Student
{
    public string Name;

    public int Age;
}

class Programm
{ 
    static void Main(string[] args)
    {
        List<Student> studentList = new List<Student>
        {
            new Student() { Name = "Camilia", Age = 18 },
            new Student() { Name = "Bob", Age = 20 },
            new Student() { Name = "Ada", Age = 18}
        };

        var query = studentList.OrderBy(student => student.Age)
            .ThenBy(student => student.Name).ToList();

        foreach (Student student in query)
        { 
            Console.WriteLine("{0} {1}", student.Name, student.Age);
        }


        Console.ReadLine();
    }
}
