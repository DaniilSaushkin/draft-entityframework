namespace draft_entityframework.fluentapi.models
{
    // Кастомная промежуточная таблица, 
    // которая хранит ссылку на игру и на пользователя
    public sealed class PublishersGames
    {
        public Guid GameID { get; set; } // Внешний ключ. Ссылка на игру
        public Game? Game { get; set; } // Навигационное свойство

        public Guid UserID { get; set; } // Внешний ключ. Ссылка на пользователя
        public User? User { get; set; } // Навигационное свойство
    }
}
