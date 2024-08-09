using AdvC_03.Part01;
using System.Diagnostics;

namespace AdvC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                ISBN = "A",
                Title = "T01",
                Authors = ["Manar", "Ali"],
                PublicationDate = DateTime.Now,
                Price = 200
            };
            // Book book = new Book("A",  "T01", new string[] { "Manar", "Ali" },  DateTime.Now,  200);
            
            //Anonymous Method
            Func< Book, string> func01;
            func01 = delegate (Book B) { return B.ISBN; };
            //Lambda Expression 
            Func<Book, DateTime> func02;
            func02 = ( B)=> B.PublicationDate;
           



        }
    }
}
