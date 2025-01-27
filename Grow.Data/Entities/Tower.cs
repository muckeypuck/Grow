using Grow.Data.Entities.Abstractions;
using Grow.Data.Entities.Types;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grow.Data.Entities
{
    public class Tower: BaseGrowEntity
    {
        public Guid TowerTypeId { get; set; }
        [ForeignKey(nameof(TowerTypeId))]
        public virtual TowerType TowerType { get; set; }


    }
}
