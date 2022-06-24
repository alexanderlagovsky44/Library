namespace Library.Models
{
    //Место где мы будем хрнаить информацию об авторах, в дальнешем можно хрнаить информацию в базе данных
    public class Authors
    {
        public int Id { get; set; } // Нужны для Базы данных

        public string name { get; set; } //Наименование автора
        public List <Book> booksauthor { get; set; } // ссылка на книги, какие авторы имеют книги
    }
}
