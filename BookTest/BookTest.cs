using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mand_Exe_1;


namespace BookTest
{
    [TestClass]
    public class BookTest
    {
        //  Book book = new Book("sdada", "dsadda", 32 , "dsada");




        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void TitleException()
        {

            Book book = new Book("s", "sda", 32, "0123456789123");
           

        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void PageException()
        {
            Book book = new Book("sdada", "dsadda", 5, "0123456789122");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void ISBNException()
        {
            Book book = new Book("sdada", "dsadda", 25, "dsada");
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void StringMethod()
        {
            Book book = new Book("sdada", "dsadda", 25, "dsada");

            book.ToString();

        }

    }
}
