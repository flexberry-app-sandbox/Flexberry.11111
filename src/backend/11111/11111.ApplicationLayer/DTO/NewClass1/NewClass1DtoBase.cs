namespace 11111.ApplicationLayer.DTO.NewClass1
{
    using System;
    using 11111;

    /// <summary>
    /// Базовое DTO для NewClass1.
    /// </summary>
    public class NewClass1DtoBase
    {
        /// <summary>
        /// Id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Заполняет ДТО данными из переданного объекта.
        /// </summary>
        /// <param name="source">Объект с данными.</param>
        /// <returns>Полученное ДТО.</returns>
        public virtual NewClass1DtoBase FillFromClass(NewClass1 source)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Заполняет переданный объект данными из ДТО.
        /// </summary>
        /// <param name="destination">Объект для обновления.</param>
        public virtual void UpdateFromDto(NewClass1 destination)
        {
            throw new NotImplementedException();
        }
    }
}
