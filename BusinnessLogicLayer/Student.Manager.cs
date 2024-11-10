using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Medicine.BusinnessLogicLayer
{
    /*//this class is responible for passing data back and fourth from 
    internal class Student
    {
        public class StudentManager
        {

            // Method to add a new student by passing the necessary details
            public static void AddStudent(int id, string name, int age, string course)
            {
                // Create a new student object using the provided details
                Student student = new Student(id, Fname, age, course);

                DataHandler.AddStudent(Student); // Add the new student to the file
            }

            // Method to remove a student by their ID
            public static void RemoveStudent(int id)
            {
                DataHandler.DeleteStudent(id);  // Call the method from the Data Layer to remove the student
            }

            // Method to update a student's details by passing the updated information
            public static void UpdateStudent(int id, string name, int age, string course)
            {
                // Create a new student object with the updated information
                Student updatedStudent = new Student(id, name, age, course);
                StudentFileManager.UpdateStudent(updatedStudent);  // Call the Data Layer to update the student in the file
            }

            // Method to get all students from the data layer
            public static List<Student> GetAllStudents()
            {
                return StudentFileManager.ReadStudentsFromFile();  // Return the list of students from the file
            }

            // Method to generate a summary report: total number of students and average age
            public static string GenerateSummaryReport()
            {
                var students = GetAllStudents();  // Get all the students
                int totalStudents = students.Count;  // Count the total number of students
                double averageAge = students.Count > 0 ? students.Average(s => s.Age) : 0;  // Calculate the average age

                // Format the summary string
                string summary = $"Total Students: {totalStudents}\nAverage Age: {averageAge:F2}";

                // Save the summary to a text file
                File.WriteAllText(@"Resources\summary.txt", summary);
                return summary;  // Return the summary string
            }
    }*/
}
