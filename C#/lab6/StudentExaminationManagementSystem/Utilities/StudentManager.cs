using SEMS.Utilities.StudentClasses;


namespace SEMS.Utilities
{
    abstract class StudentManager
    {
        public static Student FindFirst(string name)
        {
            foreach (var student in Student.AllStudents)
            {
                if (student.Name == name)
                    return student;
            }

            throw new Exception("Can't find student with the specified name");
        }


        public static Student FindFirst(int studentid)
        {
            foreach (var student in Student.AllStudents)
            {
                if (student.ID == studentid)
                    return student;
            }

            throw new Exception("Can't find student with the specified name");
        }       
    }
}