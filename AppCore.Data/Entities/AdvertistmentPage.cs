using AppCore.Infrastucture.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppCore.Data.Entities
{
    [Table("AdvertistmentPages")]
    public class AdvertistementPage : DomainEntity<string>
    {
        public string Name { get; set; }
        
        public virtual ICollection<AdvertistmentPosition> AdvertistmentPositions { get; set; }
    }
}
