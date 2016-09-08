using Newtonsoft.Json;
using ShopifySharp.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    // Extra info see: https://help.shopify.com/api/reference/event
    /// <summary>
    /// An enum that indicates an event verb <see cref="ShopifyEvent"/> not all events are created for each Subject Type
    /// </summary>
    [JsonConverter(typeof(NullableEnumConverter<ShopifyEventVerb>))]
    public enum ShopifyEventVerb
    {
        /// <summary>
        /// Create
        /// </summary>
        [EnumMember(Value = "create")]
        Create,

        /// <summary>
        /// Destroy
        /// </summary>
        [EnumMember(Value = "destroy")]
        Destroy,

        /// <summary>
        /// Published
        /// </summary>
        [EnumMember(Value = "published")]
        Published,

        /// <summary>
        /// Unpublished
        /// </summary>
        [EnumMember(Value = "unpublished")]
        Unpublished,

        /// <summary>
        /// Update
        /// </summary>
        [EnumMember(Value = "update")]
        Update,

        /// <summary>
        /// Authorization Failure
        /// </summary>
        [EnumMember(Value = "authorization_failure")]
        AuthorizationFailure,

        /// <summary>
        /// Authorization Pending
        /// </summary>
        [EnumMember(Value = "authorization_pending")]
        AuthorizationPending,

        /// <summary>
        /// Authorization Success
        /// </summary>
        [EnumMember(Value = "authorization_success")]
        AuthorizationSuccess,

        /// <summary>
        /// Cancelled
        /// </summary>
        [EnumMember(Value = "cancelled")]
        Cancelled,

        /// <summary>
        /// capture failure
        /// </summary>
        [EnumMember(Value = "capture_failure")]
        CaptureFailure,

        /// <summary>
        /// capture pending
        /// </summary>
        [EnumMember(Value = "capture_pending")]
        CapturePending,

        /// <summary>
        /// capture success
        /// </summary>
        [EnumMember(Value = "capture_success")]
        CaptureSuccess,

        /// <summary>
        /// closed
        /// </summary>
        [EnumMember(Value = "closed")]
        Closed,

        /// <summary>
        /// Fulfillment Cancelled
        /// </summary>
        [EnumMember(Value = "fulfillment_cancelled")]
        FulfillmentCancelled,

        /// <summary>
        /// Fulfillment Pending
        /// </summary>
        [EnumMember(Value = "fulfillment_pending")]
        FulfillmentPending,

        /// <summary>
        /// Fulfillment Success
        /// </summary>
        [EnumMember(Value = "fulfillment_success")]
        FulfillmentSuccess,

        /// <summary>
        /// mMil Sent
        /// </summary>
        [EnumMember(Value = "mail_sent")]
        MailSent,

        /// <summary>
        /// placed
        /// </summary>
        [EnumMember(Value = "placed")]
        Placed,

        /// <summary>
        /// Reopened
        /// </summary>
        [EnumMember(Value = "re_opened")]
        Reopened,

        /// <summary>
        /// Refund Failure
        /// </summary>
        [EnumMember(Value = "refund_failure")]
        RefundFailure,

        /// <summary>
        /// Refund Pending
        /// </summary>
        [EnumMember(Value = "refund_pending")]
        RrefundPending,

        /// <summary>
        /// Refund Success
        /// </summary>
        [EnumMember(Value = "refund_success")]
        RefundSuccess,

        /// <summary>
        /// Restock line items
        /// </summary>
        [EnumMember(Value = "restock_line_items")]
        RestockLineItems,

        /// <summary>
        /// Sale Failure
        /// </summary>
        [EnumMember(Value = "sale_failure")]
        SaleFailure,

        /// <summary>
        /// Sale Pending
        /// </summary>
        [EnumMember(Value = "sale_pending")]
        SalePending,

        /// <summary>
        /// Sale Success
        /// </summary>
        [EnumMember(Value = "sale_success")]
        SaleSuccess,

        /// <summary>
        /// Void Failure
        /// </summary>
        [EnumMember(Value = "void_failure")]
        VoidFailure,

        /// <summary>
        /// Void Pending
        /// </summary>
        [EnumMember(Value = "void_pending")]
        VoidPending,

        /// <summary>
        /// Void Success
        /// </summary>
        [EnumMember(Value = "void_success")]
        VoidSuccess
    }
}
