using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mAXS_gORN
{
    [Serializable]
    public  class Person 
    {
        public string Name { get; set; }
        public int Type { get; set; }
        public int Id { get; set; }
        public List<Book> HaveBook{ get; set; } = new List<Book>();
        public Person()
        {

        }
    }
    [Serializable]
    public class PersonList
    {
        public List<Person> People { get; set; } = new List<Person>();
        public PersonList()
        {

        }
    }

        enum TypePerson
    {
        User=1,
        Librarian=2,
        Admin=3,
    }
}
