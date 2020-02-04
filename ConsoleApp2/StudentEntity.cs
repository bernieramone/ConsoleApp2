using System.Collections.Generic;

namespace ConsoleApp2
{
    public class StudentEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<StudentEntity> GetStudentEntities()
        {
            List<StudentEntity> lstStudentEntities = new List<StudentEntity>();

            using (LinqTestEntities context = new LinqTestEntities())
            {
                var students = context.Student;

                foreach (var student in students)
                {
                    lstStudentEntities.Add(new StudentEntity
                    {
                        ID = student.id,
                        Name = student.name,
                        Gender = student.genre
                    });

                }

            }

            return lstStudentEntities;

        }
    }
}
