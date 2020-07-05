using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace mAXS_gORN
{
    [Serializable]
    public class Book
    {
        
        public string Name { get; set; }
        public string TypeBook { get; set; }
        public string Anotation { get; set; }

        public string ChanrBook { get; set; }



        public double Cost { get; set; }

        public List<string> UserNameToReturn { get; set; } = new List<string>();
        public Book()
        {

        }
       
        public int Id { get; set; }

    }

    public class ListBooks
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public ListBooks()
        {

        }
    }
}
