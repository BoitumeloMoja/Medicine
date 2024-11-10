namespace DataLayer
{
    public class Student
    {
        public string StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public Student(string studentId, string name, int age, string course)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
            Course = course;
        }

        public override string ToString()
        {
            // This will format the student data as a single line for easy writing to a file
            return $"{StudentId},{Name},{Age},{Course}";
        }

        public static Student FromString(string studentData)
        {
            // Parses a string line from students.txt to create a Student object
            var data = studentData.Split(',');
            return new Student(data[0], data[1], int.Parse(data[2]), data[3]);
        }

    }
}
