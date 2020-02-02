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
    [Table("Advertistments")]
    public class Advertistment : DomainEntity<int>, ISwitchable, ISortable
    {
        [StringLength(20)]
        public string PositionId { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Image { get; set; }

        [StringLength(250)]
        public string Url { get; set; }

        public Status Status {set;get;}
        public int SortOrder { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModyfied { set; get; }

        [ForeignKey("PositionId")]
        public virtual AdvertistmentPosition AdvertistmentPosition { get; set; }
    }
}
