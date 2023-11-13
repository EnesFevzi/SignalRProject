using SıgnalRProject.Entity.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SıgnalRProject.Entity.Entities
{
    public class MenuTable : EntityBase
    {
        public int MenuTableID { get; set; }
        public string Name { get; set; }
     
        public List<Basket> Baskets { get; set; }
    }
}
