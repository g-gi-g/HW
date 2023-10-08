using System.Text;

class Student
{
    private static string name;

    public static string Name
    {
        set { name = value; }
        get { return; }
    }
}

internal class Program
{
    static void Main() 
    {
        Console.OutputEncoding = Encoding.UTF8;
        Student.Name = "Іван";
        Console.WriteLine("Ім'я студента: " +  Student.Name);
        Console.ReadKey();
    }
    
}
