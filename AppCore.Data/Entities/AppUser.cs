using AppCore.Data.Enums;
using AppCore.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppCore.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public string FullName { get; set; }

        public DateTime? BirthDay { get; set; }

        public Decimal Balance { get; set; }

        public string Avatar { get; set; }

        public Status Status {set;get;}
        public DateTime DateCreated {set;get;}
        public DateTime DateModified {set;get;}
    }
}
