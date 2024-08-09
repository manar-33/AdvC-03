using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_03.Part01
{
    public delegate string BookFunc(Book book);
    internal class BookFunctions : Book
    {
        public BookFunctions(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price) //: base(_ISBN, _Title, _Authors, _PublicationDate, _Price)
        {
        }
        public static string GetISBN(Book B)
        {
            return B.ISBN;
        }
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static DateTime PublicationDate(Book B)
        {
            return B.PublicationDate;
        }
        public static string[] GetAuthors(Book B)
        {
            return (string[])B.Authors;
        }
        public static decimal GetPrice(Book B)
        {
            return B.Price;
        }

    }
}
