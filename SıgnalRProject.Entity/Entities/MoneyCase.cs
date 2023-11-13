using SıgnalRProject.Entity.BaseEntities;

namespace SıgnalRProject.Entity.Entities
{
    public class MoneyCase : IEntityBase
    {
        public int MoneyCaseID { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
