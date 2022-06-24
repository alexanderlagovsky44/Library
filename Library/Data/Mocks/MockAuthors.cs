using Library.Data.interfaces;
using Library.Models;

namespace Library.Data.Mocks
{
    
    public class MockAuthors : IBooksAuthors
    {
        //Реализован сам интрефейс, в котором функиця возврата и указали какие даннче будем возвращать
        public IEnumerable<Authors> AllAuthors
        {
            get
            {
                return new List<Authors>
                {
                    new Authors { name = "Фёдор Михайлович Достоевский"},
                    new Authors { name = "Лев Николаевич Толстой"}
                };
            }
        }
    }
}
