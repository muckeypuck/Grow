using System.ComponentModel.DataAnnotations;

namespace Grow.Data.Entities.Abstractions;

public class BaseGrowEntityType : BaseGrowEntity
{
    [Required]
    [MaxLength(75)]
    public string Name { get; set; }
}
