using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entity
{
    public class DishFlavor
    {
        public long Id { get; set; }
        public long Dish_Id {  get; set; }
        public string Name { get; set; }
        public string Value {  get; set; }
    }
}
