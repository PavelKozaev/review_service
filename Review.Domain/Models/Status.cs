using System.ComponentModel.DataAnnotations;

namespace Review.Domain.Models
{
    /// <summary>
    /// Статус
    /// </summary>
    public enum Status
    {
        [Display(Name = "Не указан")]
        None = 0,

        [Display(Name = "Актуальный")]
        Actual = 1,

        [Display(Name = "Удален")]
        Deleted = 2
    }
}
