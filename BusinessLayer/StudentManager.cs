using System;
using System.Collections.Generic;
using DataLayer;

namespace BusinessLayer
{
    public class StudentManager
    {
        private readonly DataHandler dataHandler;

        public StudentManager()
        {
            dataHandler = new DataHandler();
        }

        public bool AddStudent(string studentId, string name, int age, string course, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(course))
            {
                errorMessage = "All fields (Student ID, Name, Course) are required.";
                return false;
            }

            if (age < 0 || age > 120)
            {
                errorMessage = "Age must be a positive number between 0 and 120.";
                return false;
            }

            dataHandler.AddStudent(studentId, name, age, course);
            return true;
        }

        public List<Student> GetAllStudents()
        {
            return dataHandler.GetAllStudents();
        }

        public Student GetStudentById(string studentId, out string errorMessage)
        {
            errorMessage = string.Empty;
            var student = dataHandler.GetStudentById(studentId);
            if (student == null)
            {
                errorMessage = "Student not found.";
            }
            return student;
        }

        public bool UpdateStudent(string studentId, string name, int age, string course, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(studentId) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(course))
            {
                errorMessage = "All fields (Student ID, Name, Course) are required.";
                return false;
            }

            if (age < 0 || age > 120)
            {
                errorMessage = "Age must be a positive number between 0 and 120.";
                return false;
            }

            var existingStudent = dataHandler.GetStudentById(studentId);
            if (existingStudent == null)
            {
                errorMessage = "Student not found.";
                return false;
            }

            dataHandler.UpdateStudent(studentId, name, age, course);
            return true;
        }

        public bool DeleteStudent(string studentId, out string errorMessage)
        {
            errorMessage = string.Empty;
            var student = dataHandler.GetStudentById(studentId);
            if (student == null)
            {
                errorMessage = "Student not found.";
                return false;
            }

            dataHandler.DeleteStudent(studentId);
            return true;
        }

        public (int totalStudents, double averageAge) GenerateSummaryReport()
        {
            return dataHandler.GenerateSummaryReport();
        }
    }
}
