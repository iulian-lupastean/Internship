using LinqLesson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.ExtensionMethods
{
    public static class JoinsExtension
    {
        public static void JoinStudentAndHeadMaster(IEnumerable<Student> _student,IEnumerable<Faculty> _faculty)
        {

            var joinResult = _student.Join(_faculty,
                    student => student.FacultyId,
                    faculty => faculty.Id,
                    (student, faculty) => new
                    {
                        StudentName = student.FirstName,
                        StudentHeadmaster = faculty.HeadMaster,
                    }

                );
            foreach (var item in joinResult)
            {
                Console.WriteLine(item);
            }
        }

        public static void JoinStudentAndFacultyName(IEnumerable<Student> _student, IEnumerable<Faculty> _faculty)
        {

            var joinResult = _student.Join(_faculty,
                    student => student.FacultyId,
                    faculty => faculty.Id,
                    (student, faculty) => new
                    {
                        StudentName = student.LastName,
                        Faculty = faculty.Name,
                    }

                );
            foreach (var item in joinResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
