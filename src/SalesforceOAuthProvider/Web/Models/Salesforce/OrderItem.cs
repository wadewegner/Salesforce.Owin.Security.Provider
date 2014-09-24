using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class OrderItem
    {
        [Key]
        public string Id { get; set; }

        public bool IsDeleted { get; set; }

        public string OrderId { get; set; }

        public string PricebookEntryId { get; set; }

        public string OriginalOrderItemId { get; set; }

        public double? AvailableQuantity { get; set; }

        public double Quantity { get; set; }

        public double? UnitPrice { get; set; }

        public double? ListPrice { get; set; }

        public DateTimeOffset? ServiceDate { get; set; }

        public DateTimeOffset? EndDate { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

        [StringLength(30)]
        public string OrderItemNumber { get; set; }

    }
}
