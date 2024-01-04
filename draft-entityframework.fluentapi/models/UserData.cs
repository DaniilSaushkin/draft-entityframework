using System.Collections.Generic;

namespace draft_entityframework.fluentapi.models
{
    public sealed class UserData
    {
        public Guid UserDataID { get; set; }

        public required string Login { get; set; }

        /// <summary>
        /// Связь один-к-одному с пользователем.
        /// <br/><br/>
        /// Пользовательские данные - зависимая сущность, поэтому у неё хранится внешний ключ на пользователя
        /// </summary>
        public Guid UserID { get; set; } // Внешний ключ. Ссылка на пользователя

        /// <summary>
        /// Связь один-к-одному с пользователем.
        /// <br/><br/>
        /// У пользовательских данных может быть только одна ссылка на пользователя
        /// и у пользователя может быть только одна ссылка на пользовательские данные.
        /// <br/><br/>
        /// Пользовательские данные - зависимая сущность, поэтому у неё хранится внешний ключ на пользователя
        /// </summary>
        public User? User { get; set; } // Навигационное свойство
    }
}