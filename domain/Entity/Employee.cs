using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace domain.Entity
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password {  get; set; }
        public string Phone {  get; set; }
        public string Sex { get; set; }
        public string Id_Number {  get; set; }
        public int Status {  get; set; }
        public DateTime Create_Time { get; set; }
        public DateTime Update_Time { get; set; }
        public long Create_User {  get; set; }
        public long Update_User { get; set; }

        public Employee(long id, string name, string userName, string password, string phone, string sex, string id_Number, int status, DateTime create_Time, DateTime update_Time, long create_User, long update_User)
        {
            Id = id;
            Name = name;
            UserName = userName;
            Password = password;
            Phone = phone;
            Sex = sex;
            Id_Number = id_Number;
            Status = status;
            Create_Time = create_Time;
            Update_Time = update_Time;
            Create_User = create_User;
            Update_User = update_User;
        }
    }
}
