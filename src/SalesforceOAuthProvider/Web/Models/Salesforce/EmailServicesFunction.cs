using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Models.Salesforce
{
    public class EmailServicesFunction
    {
        [Key]
        public string Id { get; set; }

        public bool IsActive { get; set; }

        [StringLength(64)]
        public string FunctionName { get; set; }

        public string AuthorizedSenders { get; set; }

        public bool IsAuthenticationRequired { get; set; }

        public bool IsTlsRequired { get; set; }

        public string AttachmentOption { get; set; }

        public string ApexClassId { get; set; }

        public string OverLimitAction { get; set; }

        public string FunctionInactiveAction { get; set; }

        public string AddressInactiveAction { get; set; }

        public string AuthenticationFailureAction { get; set; }

        public string AuthorizationFailureAction { get; set; }

        public bool IsErrorRoutingEnabled { get; set; }

        [EmailAddress]
        public string ErrorRoutingAddress { get; set; }

        public bool IsTextAttachmentsAsBinary { get; set; }

        public string CreatedById { get; set; }

        public DateTimeOffset CreatedDate { get; set; }

        public string LastModifiedById { get; set; }

        public DateTimeOffset LastModifiedDate { get; set; }

        public DateTimeOffset SystemModstamp { get; set; }

    }
}
