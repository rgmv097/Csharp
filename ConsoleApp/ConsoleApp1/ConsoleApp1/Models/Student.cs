namespace ConsoleApp1.Models
{
    internal class Student
    {
        public int Id;
        public string FullName;
        public bool IsType;
        public static int Count;
        static Student()
        {

            Count = 0;
        }
        public Student(string fullName,bool isType)
        {
            FullName = fullName;
            IsType = isType;
            Id = ++Count;


        }

        public override string ToString()
        {
            return $"Fullname: {FullName},Student ID: {Id},  Status: {(IsType ? "Zemanetli" : "Zemanetsiz")}";
        }
    }
}
