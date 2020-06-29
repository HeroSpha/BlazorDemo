using BlazorDemo.Shared.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorDemo.Shared.Models
{
    public class UserContact
    {
        [Key]
        public int ContactId { get; set; }
        public ContactType ContactType { get; set; }
        public string Contact { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
