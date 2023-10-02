namespace Usr
{
    public class User
    {
        public string Login { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
        public DateTime RegistrationDate { get; }

        public User(string login, string firstName, string lastName, int age, DateTime regDate)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            RegistrationDate = regDate;
        }
        public void GetUserInfo()
        {
            Console.WriteLine($"Login: {Login}\nFirstName: {FirstName}\nLastName: {LastName}\nAge: {Age}\nRegistration Date: {RegistrationDate}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("johnnnny", "John", "Doe", 99, DateTime.Now);
            user.GetUserInfo();
            Console.ReadKey();
        }
    }
}