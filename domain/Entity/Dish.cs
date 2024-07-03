using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.Entity
{
    public class Dish
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long Category_Id {  get; set; }
        public double Price {  get; set; }
        public string Image {  get; set; }
        public string Description {  get; set; }
        public int Status {  get; set; }
        public DateTime Create_Time { get; set; }
        public DateTime Update_Time { get; set; }

        public long Create_User {  get; set; }
        public long Update_User { get; set; }
    }
}
