using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab11
{
    public class InventoryRepo
    {
        public IEnumerable<Inventory> GetAll()
        {
            using (var context = new AutoLotEntities())
            {
                return context.Inventories.ToList<Inventory>();
            }
        }
    }
}