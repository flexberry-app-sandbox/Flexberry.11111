namespace 11111.ApplicationLayer.Mapping
{
    using System;
    using 11111;
    using 11111.ApplicationLayer.DTO.NewClass1;

    /// <summary>
    /// Статический маппер для преобразования между сущностью <see cref="NewClass1"/> и её DTO.
    /// </summary>
    public static class NewClass1Mapper
    {
        /// <summary>
        /// Преобразует <see cref="NewClass1"/> в указанный DTO.
        /// </summary>
        /// <typeparam name="TDto">Тип DTO.</typeparam>
        /// <param name="source">Исходная сущность.</param>
        /// <returns>Указанный DTO.</returns>
        public static TDto MapToDto<TDto>(this NewClass1 source)
            where TDto : NewClass1DtoBase, new()
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            TDto result = new TDto();

            return (TDto)result.FillFromClass(source);
        }

        /// <summary>
        /// Обновляет поля сущности <see cref="NewClass1"/> по данным из DTO.
        /// </summary>
        /// <typeparam name="TDto">Тип DTO.</typeparam>
        /// <param name="destination">Сущность, которую нужно обновить.</param>
        /// <param name="source">DTO с новыми значениями.</param>
        public static void UpdateFromDto<TDto>(this NewClass1 destination, TDto source)
            where TDto : NewClass1DtoBase
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            if (destination == null)
            {
                throw new ArgumentNullException(nameof(destination));
            }

            source.UpdateFromDto(destination);
        }
    }
}
