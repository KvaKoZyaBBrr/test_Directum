using test_Directum.Classes;

namespace test_Directum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IPhone> phones = new List<IPhone>();
            List<User> Contacts_Z = new List<User>() { new User("A", "1-111-111-11-11"), new User("B", "2-222-222-22-22"), new User("C", "3-333-333-33-33") };
            Phone Z = new Phone("0-000-000-00-00", Contacts_Z);
            phones.Add(Z);

            List<User> Contacts_A = new List<User>() { new User("Z", "0-000-000-00-00"), new User("B", "2-222-222-22-22"), new User("C", "3-333-333-33-33") };
            Phone A = new Phone("1-111-111-11-11", Contacts_A);
            phones.Add(A);
            List<User> Contacts_C = new List<User>() { new User("A", "1-111-111-11-11"), new User("B", "2-222-222-22-22"), new User("Z", "0-000-000-00-00") };

            Phone C = new Phone("3-333-333-33-33", Contacts_C);
            phones.Add(C);

            IBase baseA = new Base();

            foreach (IPhone phone in phones)
            {
                phone.ConnectToBase(baseA);
            }

            foreach (User user in A.UserBook)
            {
                Console.WriteLine( A.CallByUserName(user));
            }
        }
    }
}