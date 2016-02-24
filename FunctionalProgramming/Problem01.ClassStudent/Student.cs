namespace Problem01.ClassStudent
{
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        public Student(
            string firstName,
            string lastName,
            int age,
            int facultyNumber,
            string phone,
            string email,
            IList<int> marks,
            int groupNumber,
            string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public string GroupName { get; set; }

        public override string ToString()
        {
            StringBuilder viewStudents = new StringBuilder();
            viewStudents.Append(this.FirstName);
            viewStudents.AppendLine(" " + this.LastName);
            viewStudents.AppendLine("Age: " + this.Age);
            viewStudents.AppendLine("Faculty Number: " + this.FacultyNumber);
            viewStudents.AppendLine("Phone: " + this.Phone);
            viewStudents.AppendLine("Email: " + this.Email);
            viewStudents.AppendLine("Group Number: " + this.GroupNumber);

            return viewStudents.ToString();
        }
    }
}
