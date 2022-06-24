using Library.Data.interfaces;
using Library.Models;

namespace Library.Data.Mocks
{
    public class MockBook : IAllBook
    {
        public IEnumerable<Book> books 
        {
            get
            {
                return new List<Book>()
                {
                    new Book { name = "Преступление и наказание "}
                }
            );
            }
        }

        public Book getobjectbook(int bookid)
        {
            throw new NotImplementedException();
        }
    }
}
