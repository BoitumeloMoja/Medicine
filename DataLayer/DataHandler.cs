using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataLayer
{
    public class DataHandler
    {
        private const string StudentFilePath = "students.txt";
        private const string SummaryFilePath = "summary.txt";

        public void AddStudent(string studentId, string name, int age, string course)
        {
            // Example of adding a student record to the file
            var newStudent = new Student(studentId, name, age, course);
            File.AppendAllText(StudentFilePath, newStudent.ToString() + Environment.NewLine);
        }

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();
            if (File.Exists(StudentFilePath))
            {
                var lines = File.ReadAllLines(StudentFilePath);
                foreach (var line in lines)
                {
                    students.Add(Student.FromString(line));
                }
            }
            return students;
        }

        public Student GetStudentById(string studentId)
        {
            return GetAllStudents().FirstOrDefault(s => s.StudentId == studentId);
        }

        public void UpdateStudent(string studentId, string name, int age, string course)
        {
            var students = GetAllStudents();
            var student = students.FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                student.Name = name;
                student.Age = age;
                student.Course = course;

                File.WriteAllLines(StudentFilePath, students.Select(s => s.ToString()));
            }
        }

        public void DeleteStudent(string studentId)
        {
            var students = GetAllStudents();
            students = students.Where(s => s.StudentId != studentId).ToList();

            File.WriteAllLines(StudentFilePath, students.Select(s => s.ToString()));
        }

        public (int totalStudents, double averageAge) GenerateSummaryReport()
        {
            var students = GetAllStudents();
            int totalStudents = students.Count;
            double averageAge = totalStudents > 0 ? students.Average(s => s.Age) : 0;

            var summary = $"Total Students: {totalStudents}, Average Age: {averageAge:F2}";
            File.WriteAllText(SummaryFilePath, summary);

            return (totalStudents, averageAge);
        }
    }
}
