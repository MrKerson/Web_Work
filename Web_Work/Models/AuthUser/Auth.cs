using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_Work.Models.AuthUser
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<User> Users { get; set; }
        public UserRole()
        {
            Roles = new List<Role>();
            Users = new List<User>();
        }
    }
}