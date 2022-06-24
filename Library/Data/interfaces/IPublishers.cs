namespace Library.Data.interfaces
{
    public interface IPublishers
    {

        //Функции, которые позволят вытягивать данные из модели

        IEnumerable <IPublishers> AllPublishers { get; } //Список который возвращает всех авторов
    }
}
