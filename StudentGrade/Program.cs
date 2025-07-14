namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("ABC");
            student1.Marks = 92;
            student1.AssignGrade();
            student1.DisplayInfo();

            Student student2 = new Student("XYZ", 85);
            student2.AssignGrade();
            student2.DisplayInfo();

            Student student3 = new Student("PQR", 65, 'D');
            student3.AssignGrade();
            student3.DisplayInfo();
        }
    }
}
