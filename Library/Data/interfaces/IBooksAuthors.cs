using Library.Models;

namespace Library.Data.interfaces
{
    public interface IBooksAuthors
    {
        //Функции, которые позволят вытягивать данные из модели
        IEnumerable<Authors> AllAuthors { get; } //Список который возвращает всех авторов
    }
}
