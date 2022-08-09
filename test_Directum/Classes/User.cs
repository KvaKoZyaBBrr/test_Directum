using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Directum.Classes
{
    public class User
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string Number { get; set; }

        public User(string name, string number, string secondName = "", string thirdName = "")
        {
            Name = name;
            SecondName = secondName;
            ThirdName = thirdName;
            Number = number;
        }

        public override string ToString()
        {
            return $"{SecondName} {Name} {ThirdName}: {Number}";
        }
    }
}
