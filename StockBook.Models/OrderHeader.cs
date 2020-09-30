using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StockBook.Models
{
    public class OrderHeader
    {

        public int Id { get; set; }

        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }
        
        [Required]
        public DateTime ShippingDate { get; set; }

        [Required]
        public double OrderTotal { get; set; }

        public string TrackingNumber { get; set; }

        public string Carrier { get; set; }

        public string  PaymentDate { get; set; }

        public string  PaymentDueDate { get; set; }

        public string TransactionId { get; set; }


        /*
         * all these attributes might already exist in application user
         * although we are adding them here becase the shopping address can be different.
         */
        public string PhoneNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string PostalCode { get; set; }
        public string Name { get; set; }


    }
}
