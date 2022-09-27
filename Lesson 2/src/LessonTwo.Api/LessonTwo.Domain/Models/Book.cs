using LessonTwo.Domain.Abstractions;

namespace LessonTwo.Domain.Models;

public class Book : Entity
{
    /// <summary>
    /// Название книги.
    /// </summary>
    public string Name { get; set; } = String.Empty;

    /// <summary>
    /// Описание книги. 
    /// </summary>
    public string Title { get; set; } = String.Empty;

    /// <summary>
    /// Регистрационный номер книги.
    /// </summary>
    public Guid RegistrationNumber { get; set; }
}
