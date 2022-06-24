using Library.Models;

namespace Library.Data.interfaces
{
    public interface IAllBook
    {
        //Функции, которые позволят вытягивать данные из модели
        IEnumerable<Book> books { get; set; } //Список который возвращает все книги

        Book getobjectbook(int bookid);//возвращает товар по его айди
    }
}
