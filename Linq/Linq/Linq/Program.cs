using Linq.ExtensionMethods;
using LinqLesson;

namespace LinqAssignment
{
    public static class LinqAssignment
    {

        static void Main(string[] args)
        {

            //OrderByExtension.OrderByFirstName(_students);
            //Console.WriteLine();
            //OrderByExtension.OrderByLastName(_students);

            // ConvertTo Dict Extension
            /* 
            var dict1 = DataConversionsExtension.ConvertToDictionaryWithID(_faculties);
            foreach (var item in dict1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            var dict2 = DataConversionsExtension.ConvertToDictionaryWithHeadMaster(_faculties);
            foreach (var item in dict2)
            {
                Console.WriteLine(item);
            }
            */
            JoinsExtension.JoinStudentAndHeadMaster(_students, _faculties);
            Console.WriteLine();

            JoinsExtension.JoinStudentAndFacultyName(_students, _faculties);


        }

        public static void SetOperations()
        {
            // Distinct
            var distinctStudents = _students.GroupBy(student => new { student.FirstName })
                .Select(student => student.First()).ToList();
            var distinctStud = _students.DistinctBy(student => student.FirstName);
            foreach (var student in distinctStud)
            {
                // Console.WriteLine(student);
            }

            //Except
            var exceptStudents = _students.Where(student => _faculties.Any(faculty => faculty.Id == student.FacultyId && faculty.HeadMaster == "Mike Tyson")).ToList();
            foreach (var exceptStudent in exceptStudents)
            {
                //   Console.WriteLine(exceptStudent);
            }

            var joinResult = _students.Join(_faculties,
                    student => student.FacultyId,
                    faculty => faculty.Id,
                    (student, faculty) => new
                    {
                        StudentName = student.FirstName,
                        StudentHeadmaster = faculty.HeadMaster,
                    }

                );
            foreach (var student in joinResult)
            {
                //Console.WriteLine(student);
            }


        }
        public static void DataConversion()
        {
            var facultyDictionary = _faculties.ToDictionary(faculty => faculty.Id, faculty => faculty.Name);
            foreach (var faculty in facultyDictionary)
            {
                Console.WriteLine(faculty);
            }
        }


        public static void ElementOperators()
        {
            Console.WriteLine("{0}", _students.First());
        }




        private static readonly IEnumerable<Student> _students = CreateStudentsList();
        private static IEnumerable<Student> CreateStudentsList()
        {
            return new List<Student>
            {
                new Student { FirstName = "Jon", LastName = "Snow", Year = 2, HasAPartTimeJob = false, Age = 20, FacultyId = "1"},
                new Student { FirstName = "Mark", LastName = "Twain", Year = 2, HasAPartTimeJob = false , Age = 21, FacultyId = "1"},
                new Student { FirstName = "Cristiano", LastName = "Ronaldo", Year = 3, HasAPartTimeJob = false, Age = 21 , FacultyId = "4"},
                new Student { FirstName = "Steve", LastName = "Jobs", Year = 4, HasAPartTimeJob = true, Age = 18, FacultyId = "3" },
                new Student { FirstName = "Adam", LastName = "Einstein", Year = 2, HasAPartTimeJob = true, Age = 19, FacultyId = "3"},
                new Student { FirstName = "Maia", LastName = "Sandu", Year = 2, HasAPartTimeJob = true , Age = 24, FacultyId = "2"},
                new Student { FirstName = "Radu", LastName = "Popescu", Year = 2, HasAPartTimeJob = true , Age = 25, FacultyId = "2"},
                new HomeStudent { FirstName = "Adam", LastName = "Gontier", Year = 3, HasAPartTimeJob = false, Address = "Selimbar, Sibiu, Ana Aslan 11", Age = 29, FacultyId = "1"},
                new HomeStudent { FirstName = "Bill", LastName = "Gates", Year = 3, HasAPartTimeJob = false, Address = "Timisoara, Strada Victoria", Age = 19, FacultyId = "5"},
                new Student { FirstName = "Winston", LastName = "Churchill", Year = 1, HasAPartTimeJob = true, Age = 30 , FacultyId = "4"},
                new Student { FirstName = "Matei", LastName = "Basarab", Year = 1, HasAPartTimeJob = false , Age = 22, FacultyId = "5"},
                new Student { FirstName = "Radu", LastName = "Stati", Year = 2, HasAPartTimeJob = true , Age = 25, FacultyId = "2"},
                new Student { FirstName = "Radu", LastName = "Stati", Year = 2, HasAPartTimeJob = true , Age = 25, FacultyId = "9"},
            };
        }

        private static readonly IEnumerable<Faculty> _faculties = CreateFacultiesList();
        private static IEnumerable<Faculty> CreateFacultiesList()
        {
            return new List<Faculty>
            {
                new Faculty { Name = "IT", Id = "1", HeadMaster = "Mike Tyson",
                    Students = new List<Student> { new Student() { FirstName = "s1" }, new Student { FirstName = "s2"} } },
                new Faculty { Name = "Marketing", Id = "2", HeadMaster = "Jonas Renkse",
                    Students = new List<Student> { new Student() { FirstName = "s3" }, new Student { FirstName = "s4"} } },
                new Faculty { Name = "Economy", Id = "3", HeadMaster = "Mark Zukerberg",
                    Students = new List<Student> { new Student() { FirstName = "s5" }, new Student { FirstName = "s6"} }},
                new Faculty { Name = "Math", Id = "4", HeadMaster = "Alfred Nobel" },
                new Faculty { Name = "Agriculture", Id = "5", HeadMaster = "Ned Stark" },
            };
        }
    }


}