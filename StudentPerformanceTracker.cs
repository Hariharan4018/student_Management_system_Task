using System;

class StudentPerformanceTracker {

    public void AddStudent(Student student) {
        student.AddStudent(student);
    }
    public void AssignGrade(Student student)
    {
        student.AssignGrade(student, student.Marks);
    }
    public void  DeleteStudentDetails(string ID)
    {
        Student.StudentDetails.Remove(ID);
    }
    public List<Student> SearchStudentDetailsByIdOrName(String FieldToSearch)
    {
       return  Student.SearchStudentDetailsByIdOrName(FieldToSearch);
    }
    public void DisplayAllStudentDetails()
    {
        Student.DisplayAllStudentDetails();
    }
    public void DisplayNumberOfStudentInEachCatogory()
    {
        Student.DisplayNumberOfStudentInEachCatogory();
    }
    public void UpdateStudentDetails()
    {
        Student.UpdateStudentDetails();
    }
}
