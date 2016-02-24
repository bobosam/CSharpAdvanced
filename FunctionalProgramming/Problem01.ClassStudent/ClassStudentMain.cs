namespace Problem01.ClassStudent
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClassStudentMain
    {
        public static void Main()
        {
            // Problem01.ClassStudent
            var students = new List<Student>
            {
                new Student("Pavel", "Pavlov", 25, 789564, "02884578", "pavel@mail.bg", new List<int> { 4, 3, 5, 6 }, 1, "first"),
                new Student("Ivo", "Antov", 28, 845312, "+35988783514", "ivo@abv.bg", new List<int> { 3, 3, 4, 6 }, 2, "second"),
                new Student("Emil", "Emilov", 22, 654714, "+3592812456", "emil@abv.bg", new List<int> { 4, 2, 2, 5 }, 3, "third"),
                new Student("Vasko", "Penev", 24, 325745, "+3598841568", "vasko@yahoo.mail", new List<int> { 4, 6, 5, 6 }, 1, "first"),
                new Student("Pavel", "Kokov", 29, 562314, "+359 2852487", "koko@mail.bg", new List<int> { 4, 6, 2, 2 }, 2, "second"),
                new Student("Gogo", "Gogov", 25, 369785, "+359873568947", "gogo@abv.bg", new List<int> { 4, 4, 4, 6 }, 3, "third"),
            };

            // Problem02.Students by Group
            var groupQuery =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;
            PrintStudents(groupQuery, 2);

            // Problem03.Students by First and Last Name
            var namesQuery =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            PrintStudents(namesQuery, 3);

            // Problem04.Students by Age
            var ageQuery =
                from student in students
                where student.Age >= 18 && student.Age <= 24
                select new { FirstName = student.FirstName, LastName = student.LastName, Age = student.Age };
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Problem: {0}", 4);
            Console.WriteLine();
            foreach (var student in ageQuery)
            {
                Console.WriteLine("{0} {1} Age: {2}", student.FirstName, student.LastName, student.Age);
            }

            // Problem05.Sort Students
            var sortedStudents = students
                                    .OrderByDescending(st => st.FirstName)
                                    .ThenByDescending(st => st.LastName);
            PrintStudents(sortedStudents, 5);

            var sortQuery =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;
            PrintStudents(sortQuery, 5);

            // Problem06.Filter Students by Email Domain
            var abvEmails = students
                    .Where(st => st.Email.Contains("@abv.bg"));
            PrintStudents(abvEmails, 6);

            // Problem07.Filter Students by Phone
            var phoneSelectStudents = students
                                        .Where(st =>
                                        st.Phone.StartsWith("02") ||
                                        st.Phone.StartsWith("+3592") ||
                                        st.Phone.StartsWith("+359 2"));
            PrintStudents(phoneSelectStudents, 7);

            // Problem08.Excellent Students
            var excellentStudents = students
                                        .Where(st => st.Marks.Contains(6))
                                        .Select(st => new
                                        {
                                            FirstName = st.FirstName,
                                            LastName = st.LastName,
                                            Marks = st.Marks
                                        });
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Problem: {0}", 8);
            Console.WriteLine();
            foreach (var student in excellentStudents)
            {
                Console.WriteLine(
                    "{0} {1} Marks: {2}",
                    student.FirstName,
                    student.LastName,
                    string.Join(", ", student.Marks));
            }

            // Problem09.Weak Students
            var weakStudents = students
                                    .Where(st => st.Marks.Count(m => m == 2) == 2)
                                    .Select(st => new
                                    {
                                        FirstName = st.FirstName,
                                        LastName = st.LastName,
                                        Marks = st.Marks
                                    });
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Problem: {0}", 9);
            Console.WriteLine();
            foreach (var student in weakStudents)
            {
                Console.WriteLine(
                    "{0} {1} Marks: {2}",
                    student.FirstName,
                    student.LastName,
                    string.Join(", ", student.Marks));
            }

            // Problem10. Students Enrolled in 2014
            var enrolledStudents = students
                                    .Where(st => st.FacultyNumber % 100 == 14)
                                    .Select(st => new
                                    {
                                        FirstName = st.FirstName,
                                        LastName = st.LastName,
                                        FacultyNumber = st.FacultyNumber,
                                        Marks = st.Marks
                                    });
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Problem: {0}", 10);
            Console.WriteLine();
            foreach (var student in enrolledStudents)
            {
                Console.WriteLine(
                    "{0} {1} Faculty Number: {2} Marks: {3}",
                    student.FirstName,
                    student.LastName,
                    student.FacultyNumber,
                    string.Join(", ", student.Marks));
            }

            // Problem11.Students by Groups
            var groupsQuery =
                from student in students
                group student by student.GroupName;
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Problem: {0}", 11);
            Console.WriteLine();
            foreach (var group in groupsQuery)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
                }

                Console.WriteLine();
            }

            // Problem12. Students Joined to Specialties
            var speciality = new List<StudentSpecialty>
                                            {
                                                new StudentSpecialty("C#", 789564),
                                                new StudentSpecialty("C#", 845312),
                                                new StudentSpecialty("PHP", 654714),
                                                new StudentSpecialty("PHP", 325745),
                                                new StudentSpecialty("Java", 562314),
                                                new StudentSpecialty("Java", 369785)
                                            };
            var joinData = students
                        .Join(
                            speciality,
                            st => st.FacultyNumber,
                            sp => sp.FacultyNumber,
                            (st, sp) => new
                            {
                                Name = st.FirstName + " " + st.LastName,
                                FacNum = st.FacultyNumber,
                                Speciality = sp.Speciality
                            });
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Problem: {0}", 12);
            Console.WriteLine();
            foreach (var student in joinData)
            {
                Console.WriteLine(
                    "{0} Faculty Number: {1} Speciality: {2}",
                    student.Name,
                    student.FacNum,
                    student.Speciality);
            }
        }

        private static void PrintStudents(IEnumerable<Student> inputQuery, int problemNumber)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Problem: {0}", problemNumber);
            Console.WriteLine();
            foreach (var student in inputQuery)
            {
                Console.WriteLine(student);
            }
        }
    }
}
