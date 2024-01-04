using System.Collections.Generic;

namespace draft_entityframework.fluentapi.models
{
    public sealed class Review
    {
        public Guid ReviewID { get; set; }

        public required string Comment { get; set; }

        public bool IsRecommend { get; set; }

        /// <summary>
        /// Связь один-ко-многим с игрой.
        /// <br/><br/>
        /// Так как связь один-ко-многим и у отзыва может быть только одна игра, 
        /// значит отзыв это зависимая сущность и отзыв должен хранить ссылку на игру
        /// </summary>
        public Guid GameID { get; set; } // Внешний ключ. Ссылка на игру

        /// <summary>
        /// Связь один-ко-многим с игрой.
        /// <br/><br/>
        /// Отзыв может быть только у одной игры,
        /// но у игры может быть много отзывов
        /// </summary>
        public required Game Game { get; set; } // Навигационное свойство

        /// <summary>
        /// Связь один-ко-многим с создателем (пользователем) отзыва.
        /// <br/><br/>
        /// Так как  связь один-ко-многим и у отзыва может быть может быть только один создатель,
        /// значит отзыв зависимая сущность и она должна хранить ссылку на пользователя
        /// </summary>
        public Guid CreaterID { get; set; } // Внешний ключ. Ссылка на пользователя
        /// <summary>
        /// Связь один-ко-многим с создателем (пользователем) отзыва.
        /// <br/><br/>
        /// У отзыва может быть только один создатель (пользователь),
        /// но у пользователя может быть много отзывов
        /// </summary>
        public required User Creater { get; set; } // Навигационное свойство
    }
}