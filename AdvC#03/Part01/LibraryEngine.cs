using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_03.Part01
{
    internal class LibraryEngine : BookFunctions
    {
        public LibraryEngine(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price) : base(_ISBN, _Title, _Authors, _PublicationDate, _Price)
        {
        }
        public static void ProcessBooks(List<Book> Blist ,BookFunc fPtr) 
        {
            Console.WriteLine(fPtr);
        }
    }
}
