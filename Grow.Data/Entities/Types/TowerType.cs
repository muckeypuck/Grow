using Grow.Data.Entities.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grow.Data.Entities.Types
{
    [Table("TowerTypes")]
    public class TowerType : BaseGrowEntityType
    {
        public Guid BedTypeId { get; set; }
        [ForeignKey(nameof(BedTypeId))]
        public virtual BedType BedType { get; set; }
        public int Sides { get; set; }
        public int BedsPerside { get; set; }
    }
}
