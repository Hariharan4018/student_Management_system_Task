using System;
public abstract class Student
{
    public static Dictionary<string, Student> StudentDetails = new Dictionary<string, Student>();
    public string Student_Id { get; set; }
    public string Student_Name { get; set; }
    public string Student_Email { get; set; }
    public string Grade { get; set; }
    public List<double> Marks { get; set; } = new List<double>();
    public Student()
    {

    }
    public Student(string Student_Name,string Student_Email,List<double> Marks)
    {
        this.Student_Name = Student_Name;
        this.Student_Email = Student_Email;
        this.Marks = Marks;
  
    }
    public double CalculateAverage(List<double> Marks)
    {
        return Marks.Average();
    }
    public void AddStudent(Student student)
    {
        Student.StudentDetails.Add(student.Student_Id, student);
    }
    public static List<Student> SearchStudentDetailsByIdOrName(string FieldToSearch)
    {
        if (Student.StudentDetails.ContainsKey(FieldToSearch))
        {
            return new List<Student> { Student.StudentDetails[FieldToSearch] };
        }
        return Student.StudentDetails.ToList().Where(x => x.Value.Student_Name.ToLower().Equals(FieldToSearch.ToLower())).Select(x=>x.Value).ToList();
    }
    public static void DisplayAllStudentDetails()
    {
        Console.WriteLine($"{new string(' ', 10)}StudentId{new string(' ', 10)}StudentName{new string(' ', 10)}StudentGrade{new string(' ',10)}Mark1{new string(' ',10)}Mark2{new string(' ', 10)}Mark3{new string(' ', 10)}Mark4{new string(' ', 10)}Mark5");
        foreach(Student student in StudentDetails.Values)
        {
            Console.WriteLine($"{new string(' ', 10)}{student.Student_Id}{new string(' ', "StudentId".Length + 10 - student.Student_Id.Length)}{student.Student_Name}{new string(' ', "StudentName".Length + 10 - student.Student_Name.Length)}{student.Grade}{new string(' ', 10 + "StudentGrade".Length - student.Grade.Length)}{student.Marks[0]}{new string(' ', 15 - student.Marks[0].ToString().Length)}{student.Marks[1]}{new string(' ', 15 - student.Marks[1].ToString().Length)}{student.Marks[2]}{new string(' ', 15 - student.Marks[2].ToString().Length)}{student.Marks[3]}{new string(' ', 15 - student.Marks[3].ToString().Length)}{student.Marks[4]}");
        }

    }
    public static void DisplayNumberOfStudentInEachCatogory()
    {
        int Aplus = StudentDetails.Where(x => x.Value.Grade.Equals("A+")).Select(x => x.Value).Count();
        int A = StudentDetails.Where(x => x.Value.Grade.Equals("A")).Select(x => x.Value).Count();
        int B = StudentDetails.Where(x => x.Value.Grade.Equals("B")).Select(x => x.Value).Count();
        int C = StudentDetails.Where(x => x.Value.Grade.Equals("C")).Select(x => x.Value).Count();
        int D = StudentDetails.Where(x => x.Value.Grade.Equals("D")).Select(x => x.Value).Count();
        int F = StudentDetails.Where(x => x.Value.Grade.Equals("F")).Select(x => x.Value).Count();
        int Pass = StudentDetails.Where(x => x.Value.Grade.Equals("Pass")).Select(x => x.Value).Count();
        int Fail = StudentDetails.Where(x => x.Value.Grade.Equals("Fail")).Select(x => x.Value).Count();
        Console.WriteLine(new string('-', 100));
        Console.WriteLine("Regular student Details in each Catogory");
        Console.WriteLine(new string('-', 100));

        Console.WriteLine("A+  =" + Aplus);
        Console.WriteLine("A   =" +A);
        Console.WriteLine("B   ="+B);
        Console.WriteLine("C   =" + C);
        Console.WriteLine("D   =" + D);
        Console.WriteLine("F   =" + F);
        Console.WriteLine(new string('-', 100));
        Console.WriteLine("Exchange student Details in each Catogory");
        Console.WriteLine("Pass  =" + Pass);
        Console.WriteLine("Fail  =" +Fail);
    }

    public abstract void AssignGrade(Student student,List<double> Marks);
    public abstract string CalculateGrade(List<double> Marks);
}
