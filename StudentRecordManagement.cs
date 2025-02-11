using System;

namespace StudentRecordManagement
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public Student Next { get; set; }

        public Student(int rollNumber, string name, int age, string grade)
        {
            RollNumber = rollNumber;
            Name = name;
            Age = age;
            Grade = grade;
            Next = null;
        }
    }

    public class StudentList
    {
        private Student head;

        public void AddStudentAtBeginning(int rollNumber, string name, int age, string grade)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            newStudent.Next = head;
            head = newStudent;
        }

        public void AddStudentAtEnd(int rollNumber, string name, int age, string grade)
        {
            Student newStudent = new Student(rollNumber, name, age, grade);
            if (head == null)
            {
                head = newStudent;
                return;
            }
            Student temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newStudent;
        }

        public void AddStudentAtPosition(int rollNumber, string name, int age, string grade, int position)
        {
            if (position < 1)
            {
                Console.WriteLine("Position should be >= 1.");
                return;
            }
            if (position == 1)
            {
                AddStudentAtBeginning(rollNumber, name, age, grade);
                return;
            }
            Student newStudent = new Student(rollNumber, name, age, grade);
            Student temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.Next;
            }
            if (temp == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }
            newStudent.Next = temp.Next;
            temp.Next = newStudent;
        }

        public void DeleteStudentByRollNumber(int rollNumber)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }
            if (head.RollNumber == rollNumber)
            {
                head = head.Next;
                return;
            }
            Student temp = head;
            while (temp.Next != null && temp.Next.RollNumber != rollNumber)
            {
                temp = temp.Next;
            }
            if (temp.Next == null)
            {
                Console.WriteLine("Student with Roll Number {0} not found.", rollNumber);
                return;
            }
            temp.Next = temp.Next.Next;
        }

        public Student SearchStudentByRollNumber(int rollNumber)
        {
            Student temp = head;
            while (temp != null)
            {
                if (temp.RollNumber == rollNumber)
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }

        public void DisplayAllStudents()
        {
            Student temp = head;
            while (temp != null)
            {
                Console.WriteLine("Roll Number: {0}, Name: {1}, Age: {2}, Grade: {3}", temp.RollNumber, temp.Name, temp.Age, temp.Grade);
                temp = temp.Next;
            }
        }

        public void UpdateStudentGrade(int rollNumber, string newGrade)
        {
            Student student = SearchStudentByRollNumber(rollNumber);
            if (student != null)
            {
                student.Grade = newGrade;
            }
            else
            {
                Console.WriteLine("Student with Roll Number {0} not found.", rollNumber);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StudentList studentList = new StudentList();

            studentList.AddStudentAtEnd(1, "Yug", 20, "A");
            studentList.AddStudentAtEnd(2, "Deep", 22, "B");
            studentList.AddStudentAtBeginning(3, "Priya", 19, "C");

            Console.WriteLine("All Students:");
            studentList.DisplayAllStudents();

            Console.WriteLine("\nSearching for student with Roll Number 2:");
            Student student = studentList.SearchStudentByRollNumber(2);
            if (student != null)
            {
                Console.WriteLine("Found: Roll Number: {0}, Name: {1}, Age: {2}, Grade: {3}", student.RollNumber, student.Name, student.Age, student.Grade);
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            Console.WriteLine("\nUpdating grade for student with Roll Number 1:");
            studentList.UpdateStudentGrade(1, "A+");
            studentList.DisplayAllStudents();

            Console.WriteLine("\nDeleting student with Roll Number 3:");
            studentList.DeleteStudentByRollNumber(3);
            studentList.DisplayAllStudents();
        }
    }
}