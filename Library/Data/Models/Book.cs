namespace Library.Models
{
    //Место где мы будем хрнаить информацию о книгах, в дальнейшем можно хрнаить информацию в базе данных
    public class Book
    {
        public int Id { get; set; } // Нужны для Базы данных

        public string name { get; set; } //Название

        public string desc { get; set; } //Описание

        public string artic { get; set; } // Артикул книги 

        public bool IsFavorite { get; set; } //Флаг, статус прочтения

        public int IdAuthor { get; set; } // айди Автора

        public int IdPublisher { get; set; } // айди Публикации


        public virtual Authors Author { get; set; } // Ссылка на Авторов
    }
}
