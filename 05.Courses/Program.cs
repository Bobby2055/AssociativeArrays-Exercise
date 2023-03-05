namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            Dictionary<string, int> counts = new Dictionary<string, int>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var course = input[0].Trim();

                if (course == "end")
                {
                    break;
                }
                var name = input[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());

                }

                courses[course].Add(name);



            }
            PrintCoursesInfo(courses);

        }

        private static void PrintCoursesInfo(Dictionary<string, List<string>> courses)
        {
            foreach (var course in courses)
            {
                string courseName = course.Key;
                var students = course.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"--{student}");
                }

            }
        }
    }
}