using AppCore.Data.Enums;
using AppCore.Data.Interfaces;
using AppCore.Infrastucture.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppCore.Data.Entities
{
    [Table("Bills")]
    public class Bill : DomainEntity<int>, IDateTracking, ISwitchable
    {
        public Bill() { }

        public Bill(int id, string customerName, string customeAddress, string customerMobile, string customerMessage,
            BillStatus billStatus, PaymentMethod paymentMethod, Status status, string customerId) 
        {
            Id = id;
            CustomerName = customerName;
            CustomerAddress = customerName;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }

        public Bill(string customerName, string customeAddress, string customerMobile, string customerMessage,
            BillStatus billStatus, PaymentMethod paymentMethod, Status status, string customerId)
        {
            CustomerName = customerName;
            CustomerAddress = customerName;
            CustomerMobile = customerMobile;
            CustomerMessage = customerMessage;
            BillStatus = billStatus;
            PaymentMethod = paymentMethod;
            Status = status;
            CustomerId = customerId;
        }

        [StringLength(450)]
        public string CustomerId { get; set; }

        [Required]
        [StringLength(256)]
        public string CustomerName { get; set; }

        [Required]
        [StringLength(256)]
        public string CustomerAddress { get; set; }

        [Required]
        [StringLength(256)]
        public string CustomerEmail { get; set; }

        [Required]
        [StringLength(50)]
        public string CustomerMobile { get; set; }

        [Required]
        [StringLength(256)]
        public string CustomerMessage { get; set; }

        public PaymentMethod PaymentMethod { get; set; }

        public BillStatus BillStatus { get; set; }

        [DefaultValue(Status.Active)]
        public Status Status { set; get; } = Status.Active;
        public DateTime DateCreated {set;get;}
        public DateTime DateModified {set;get;}

        [ForeignKey("CustomerId")]
        public virtual AppUser User { get; set; }

        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}
