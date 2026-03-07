namespace Task_5
{
    class Person // Base class for Student and Instructor Bonus idea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void PrintBasicInfo()
        {
            Console.WriteLine($"ID: {Id} Name: {Name}");
        }
    }
    class Student : Person
    {
        public int Age { get; set; }
        public List<Course> Courses { get; set; }
        public Student(int id, string name, int age) : base(id, name)
        {
            Age = age;
            Courses = new List<Course>();
        }
        public bool Enroll(Course course)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i] == course)
                {
                    Console.WriteLine("The course is already enrolled");
                    return false;
                }
            }
            Console.WriteLine("Course is added successfuly");
            Courses.Add(course);
            return true;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Student ID: {Id} Name: {Name} Age: {Age}");
            for(int i = 0; i < Courses.Count; i++)
            {
                Console.WriteLine($"Course Title : {Courses[i].Title} ID : {Courses[i].CourseId} Instructor: {Courses[i].Instructor.Name}");
            }
            
        }
    }
    class Instructor : Person
    {
        public string Specialization { get; set; }
        public Instructor(int id, string name, string specialization)
            : base(id, name)
        {
            Specialization = specialization;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Instructor Name : {Name}  ID: {Id}  Specialization: {Specialization}");
        }
    }
    class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public Instructor Instructor { get; set; }
        public Course(int id, string title, Instructor instructor)
        {
            CourseId = id;
            Title = title;
            Instructor = instructor;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"Course Title : {Title} ID : {CourseId} Instructor: {Instructor.Name}");
        }
    }
    class StudentManager
    {
        public List<Student> Students = new List<Student>();
        public List<Course> Courses = new List<Course>();
        public List<Instructor> Instructors = new List<Instructor>();
        public bool AddStudent(Student student)
        {
            for(int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Id == student.Id)
                {
                    Console.WriteLine("The student is already added");
                    return false;
                }
            }
            Students.Add(student);
            Console.WriteLine("Student is added");
            return true;
        }
        public bool AddInstructor(Instructor instructor)
        {
            for (int i = 0; i < Instructors.Count; i++)
            {
                if (Instructors[i].Id == instructor.Id)
                {
                    Console.WriteLine("The instructor is already added");
                    return false;
                }
            }
            Instructors.Add(instructor);
            Console.WriteLine("Instructor is added");
            return true;
        }
        public bool AddCourse(Course course)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].CourseId == course.CourseId)
                {
                    Console.WriteLine("The course is already added");
                    return false;
                }
            }
            Courses.Add(course);
            Console.WriteLine("Course is added");
            return true;
        }
        public Student FindStudent(int id)
        {
            Student result = null; // to store the student in and return it after checking
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Id == id)
                {
                    result = Students[i];
                    break;
                }
            }
            return result;
        }
        public Course FindCourse(int id)
        {
            Course result = null; // to store the course in and return it after checking
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].CourseId == id)
                {
                    result = Courses[i];
                    break;
                }
            }
            return result;
        }
        public Instructor FindInstructor(int id)
        {
            Instructor result = null; // to store the instructor in and return it after checking
            for (int i = 0; i < Instructors.Count; i++)
            {
                if (Instructors[i].Id == id)
                {
                    result = Instructors[i];
                    break;
                }
            }
            return result;
        }
        public bool EnrollStudentInCourse(int studentId, int courseId)
        {
            Student student = FindStudent(studentId);
            Course course = FindCourse(courseId);
            if (student != null && course != null)
            {
                Console.WriteLine("Student is enrolled");
                return student.Enroll(course); // returns true from calling the enroll method which is boolean
            }
            Console.WriteLine("Student isn't added");
            return false;
        }
        // bonus
        public bool IsStudentEnrolled(int studentId, int courseId)
        {
            Student student = FindStudent(studentId);
            if (student == null)// if the student isn't found
                return false;
            for (int i = 0; i < student.Courses.Count; i++)
            {
                if (student.Courses[i].CourseId == courseId)
                {
                    Console.WriteLine("is enrolled");
                    return true;
                }
            }
            return false;
        }
        // bonus
        public string GetInstructorNameByCourse(string courseName)
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                if (Courses[i].Title == courseName)
                {
                    return Courses[i].Instructor.Name;
                }
            }
            return "Course not found";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            Console.WriteLine("1 Add Student");
            Console.WriteLine("2 Add Instructor");
            Console.WriteLine("3 Add Course");
            Console.WriteLine("4 Enroll Student in Course");
            Console.WriteLine("5 Show Students");
            Console.WriteLine("6 Show Courses");
            Console.WriteLine("7 Show Instructors");
            Console.WriteLine("8 Find student by ID");
            Console.WriteLine("9 Find course by ID");
            Console.WriteLine("10 Check if the student enrolled in specific course");
            Console.WriteLine("11 Return the instructor name by course name");
            Console.WriteLine("12 Exit");
            while (true)
            {
                Console.WriteLine("Enter Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Student ID: ");
                        int sid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Name: ");
                        string sname = Console.ReadLine();
                        Console.WriteLine("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Student s = new Student(sid, sname, age);
                        manager.AddStudent(s);
                        break;
                    case 2:
                        Console.WriteLine("Instructor ID: ");
                        int iid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Name: ");
                        string iname = Console.ReadLine();
                        Console.WriteLine("Specialization: ");
                        string spec = Console.ReadLine();
                        Instructor inst = new Instructor(iid, iname, spec);
                        manager.AddInstructor(inst);
                        break;
                    case 3:
                        Console.WriteLine("Course ID: ");
                        int cid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Title: ");
                        string title = Console.ReadLine();
                        Console.WriteLine("Instructor ID: ");
                        int insId = Convert.ToInt32(Console.ReadLine());
                        Instructor instructor = manager.FindInstructor(insId); 
                        if (instructor != null)
                        {
                            Course c = new Course(cid, title, instructor);
                            manager.AddCourse(c);
                        }
                        else
                        {
                            Console.WriteLine("Instructor not found");
                        }
                        break;
                    case 4:
                        Console.Write("Student ID: ");
                        int stId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Course ID: ");
                        int coId = Convert.ToInt32(Console.ReadLine());
                        if (manager.EnrollStudentInCourse(stId, coId))
                            Console.WriteLine("Enrollment successful");
                        else
                            Console.WriteLine("Enrollment failed");
                        break;
                    case 5:
                        for(int i = 0; i < manager.Students.Count; i++)
                        {
                            manager.Students[i].PrintDetails();
                        }
                        break;
                    case 6:
                        for (int i = 0; i < manager.Courses.Count; i++)
                        {
                            manager.Courses[i].PrintDetails();
                        }
                        break;
                    case 7:
                        for (int i = 0; i < manager.Instructors.Count; i++)
                        {
                            manager.Instructors[i].PrintDetails();
                        }
                        break;
                    case 8:
                        Console.WriteLine("Student ID: ");
                        int findStId = Convert.ToInt32(Console.ReadLine());
                        Student foundStudent = manager.FindStudent(findStId);
                        if (foundStudent != null)
                            foundStudent.PrintDetails();
                        else
                            Console.WriteLine("Student not found");
                        break;
                    case 9:
                        Console.WriteLine("Course ID: ");
                        int findCoId = Convert.ToInt32(Console.ReadLine());
                        Course foundCourse = manager.FindCourse(findCoId);
                        if (foundCourse != null)
                            foundCourse.PrintDetails();
                        else
                            Console.WriteLine("Course not found");
                        break;
                    case 10:
                        Console.WriteLine("Student ID: ");
                        int checkStId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Course ID: ");
                        int checkCoId = Convert.ToInt32(Console.ReadLine());
                        if (manager.IsStudentEnrolled(checkStId, checkCoId))
                            Console.WriteLine("The student is enrolled in the course");
                        else
                            Console.WriteLine("The student isn't enrolled in the course");
                        break;
                    case 11:
                        Console.WriteLine("Course Name: ");
                        string checkCourseName = Console.ReadLine();
                        string instructorName = manager.GetInstructorNameByCourse(checkCourseName);
                        Console.WriteLine($"Instructor Name: {instructorName}");
                        break;
                    case 12:
                        Console.WriteLine("Exiting...");
                        return;
                }
            }
        }
    }
}
