namespace ConsoleApp1
{
    internal class Student
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public Student(string name, string surname)
        {
            Name = name;
            SurName = surname;
        }
        public string FullName()
        {
            
            string fullname =Name + " " + SurName;
            return fullname;
        }
    }

}
