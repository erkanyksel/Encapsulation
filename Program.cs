internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new Student();

        student.Name = "John";
        student.SurName = "Doe";
        student.StudentNo = 302;
        student.Clas = 3;

        student.GetStudentInformation();


        student.RaiseClass();
        student.GetStudentInformation();


        Student student1 = new Student("Deniz", "Arda", 256, 1);
        student1.EraseClass();
        student1.EraseClass();
        student1.GetStudentInformation();

    }
}
class Student
{
    private string name;
    private string surName;
    private int studentNo;
    private int clas;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string SurName { get => surName; set => surName = value; }
    public int StudentNo { get => studentNo; set => studentNo = value; }
    public int Clas
    {
        get => clas;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Class value must be at least 1");
                clas = 1;
            }
            else
                clas = value;
        }
    }

    public Student(string name, string surName, int studentNo, int clas)
    {
        Name = name;
        SurName = surName;
        StudentNo = studentNo;
        Clas = clas;
    }
    public Student()
    { }

    public void GetStudentInformation()
    {
        Console.WriteLine("**********Student Information*********************");
        Console.WriteLine("Student Name {0}", this.Name);
        Console.WriteLine("Student SurName {0}", this.SurName);
        Console.WriteLine("Student No {0}", this.StudentNo);
        Console.WriteLine("Student Class {0}", this.Clas);
    }

    public void RaiseClass()
    {
        this.Clas = this.Clas + 1;
    }

    public void EraseClass()
    {
        this.Clas = this.Clas - 1;
    }

}