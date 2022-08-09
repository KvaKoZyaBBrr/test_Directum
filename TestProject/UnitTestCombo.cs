using test_Directum.Classes;

namespace TestProject
{
    [TestClass]
    public class UnitTestCombo
    {
        List<IPhone> phones = new List<IPhone>();
        List<User> Contacts_Z;
        IPhone Z;
        List<User> Contacts_A;
        IPhone A;
        List<User> Contacts_C;
        IPhone C;
        List<User> Contacts_D;
        IPhone D;


        IBase baseA = new Base();
        IBase baseB = new Base3G();

        [TestInitialize]
        public void init() {
            Contacts_Z = new List<User>() { new User("A", "1-111-111-11-11"), new User("B", "2-222-222-22-22"), new User("C", "3-333-333-33-33") };
            Z = new Phone("0-000-000-00-00", Contacts_Z);
            phones.Add(Z);

            Contacts_A = new List<User>() { new User("Z", "0-000-000-00-00"), new User("B", "2-222-222-22-22"), new User("C", "3-333-333-33-33") };
            A = new Phone3G("1-111-111-11-11", Contacts_A);
            phones.Add(A);

            Contacts_C = new List<User>() { new User("A", "1-111-111-11-11"), new User("B", "2-222-222-22-22"), new User("Z", "0-000-000-00-00") };
            C = new Phone("3-333-333-33-33", Contacts_C);
            phones.Add(C);

            Contacts_D = new List<User>() { new User("Z", "0-000-000-00-00"), new User("A", "1-111-111-11-11"), new User("C", "3-333-333-33-33") };
            D = new Phone3G("4-444-444-44-44", Contacts_C);
            phones.Add(D);


            foreach (IPhone phone in phones)
            {
                phone.ConnectToBase(baseA);
            }
            foreach (IPhone phone in phones)
            {
                phone.ConnectToBase(baseB);
            }
        }


        
        [TestMethod]
        public void TestCallContatList_A() {
            bool[] asserts = new bool[3] { false, false, false };
            for (int i = 0; i < Contacts_A.Count(); i++)
            {
                Assert.IsTrue(A.CallByUserName(Contacts_A[i]) == asserts[i]);
            }
        }

        [TestMethod]
        public void TestCallContatList_Z()
        {
            bool[] asserts = new bool[3] { false, false, true };
            for (int i = 0; i < Contacts_Z.Count(); i++)
            {
                Assert.IsTrue(Z.CallByUserName(Contacts_Z[i]) == asserts[i]);
            }
        }

        [TestMethod]
        public void TestCallContatList_C()
        {
            bool[] asserts = new bool[3] { false, false, true };
            for (int i = 0; i < Contacts_C.Count(); i++)
            {
                Assert.IsTrue(C.CallByUserName(Contacts_C[i]) == asserts[i]);
            }
        }

        [TestMethod]
        public void TestCallContatList_D()
        {
            bool[] asserts = new bool[3] { false, true, false };
            for (int i = 0; i < Contacts_D.Count(); i++)
            {
                Assert.IsTrue(D.CallByUserName(Contacts_D[i]) == asserts[i]);
            }
        }

    }
}