using AppCore.Data.Enums;
using AppCore.Data.Interfaces;
using AppCore.Infrastucture.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppCore.Data.Entities
{
    [Table("Announcements")]
    public class Announcement : DomainEntity<string>, ISwitchable, IDateTracking
    {
        [StringLength(250)]
        public string Content { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(450)]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }

        public virtual ICollection<AnnouncementUser> AnnouncementUsers { get; set; }

        public DateTime DateCreated {set;get;}
        public DateTime DateModified {set;get;}
        public Status Status {set;get;}
    }
}
