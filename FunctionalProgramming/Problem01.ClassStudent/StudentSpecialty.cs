namespace Problem01.ClassStudent
{
    public class StudentSpecialty
    {
        public StudentSpecialty(string speciality, int facultyNumber)
        {
            this.Speciality = speciality;
            this.FacultyNumber = facultyNumber;
        }

        public string Speciality { get; set; }

        public int FacultyNumber { get; set; }
    }
}
