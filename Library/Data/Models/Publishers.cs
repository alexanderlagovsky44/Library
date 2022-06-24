using Library.Models;

namespace Library.Data.Models
{
    //Место где мы будем хрнаить информацию об изданиях, в дальнешем можно хрнаить информацию в базе данных
    public class Publishers
    {
        public int Id { get; set; } // Нужны для Базы данных

        public string NamePublisher { get; set; } //Наименование издателя
        public List<Book> bookspublisher { get; set; } // ссылка на книги, какие авторы имеют книги
    }
}
