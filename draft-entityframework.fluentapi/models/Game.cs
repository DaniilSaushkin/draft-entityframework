namespace draft_entityframework.fluentapi.models
{
    public sealed class Game
    {
        public Guid GameID { get; set; }

        public required string Name { get; set; }

        public string? Description { get; set; }

        /// <summary>
        /// Связь многие-ко-многим с разработчиками (пользователями).
        /// <br/><br/>
        /// У игры может быть много разработчиков
        /// и у разработчика может быть много игр.
        /// <br/><br/>
        /// Разработчик это пользователь
        /// </summary>
        public List<User> Developers { get; set; } = new List<User>(); // Навигационное свойство
        /// <summary>
        /// Кастомная таблица для связи многие-ко-многим у игры с пользователем
        /// </summary>
        public List<DevelopersGames> DevelopersGames { get; set; } = new List<DevelopersGames>(); // Навигационное свойство

        /// <summary>
        /// Связь многие-ко-многим с издателями (пользователями).
        /// <br/><br/>
        /// У игры может быть много издателей 
        /// и у издателя может быть много игр.
        /// <br/><br/>
        /// Издатель это пользователь
        /// </summary>
        public List<User> Publishers { get; set; } = new List<User>(); // Навигационное свойство
        /// <summary>
        /// Кастомная таблица для связи многие-ко-многим у игры с пользователем
        /// </summary>
        public List<PublishersGames> PublishersGames { get; set; } = new List<PublishersGames>(); // Навигационное свойство

        /// <summary>
        /// Связь один-ко-многим с отзывами.
        /// <br/><br/>
        /// У игры может быть много отзывов, 
        /// но отзыв может быть оставлен только для одной конкретной игры
        /// </summary>
        public List<Review> Reviews { get; set; } = new List<Review>(); // Навигационное свойство
    }
}
