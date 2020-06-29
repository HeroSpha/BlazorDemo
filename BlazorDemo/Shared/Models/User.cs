using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorDemo.Shared.Models
{
    public class User
    {
        public User()
        {
            Cars = new HashSet<Car>();
            UserContacts = new HashSet<UserContact>();
        }
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
        public virtual ICollection<UserContact> UserContacts { get; set; }
        public void AddPerson(User user)
        {
            var contact = new UserContact();
            contact.ContactType = Interface.ContactType.Cellphone;
        }
    }
}
