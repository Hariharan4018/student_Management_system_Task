using System;

class Exchangestudent : Student
{
    static int IdCounter = 0;
    public Exchangestudent(string Student_Name, string Student_Email, List<double> Marks) : base(Student_Name, Student_Email, Marks)
    {
        this.Student_Id = "E" + ++IdCounter;
    }
    public  void AddStudent(Student  student)
    {
        base.AddStudent(student);
    }
    public override void AssignGrade(Student student,List<double> Marks)
    {
        student.Grade = CalculateGrade(Marks);
    }
    public override string CalculateGrade(List<double> Marks)
    {
        double Average = CalculateAverage(Marks);
        return Average >= 60 ? "Pass":"Fail";
    }
    public double CalculateAvreage(List<double> Marks)
    {
        return base.CalculateAverage(Marks);
    }
}