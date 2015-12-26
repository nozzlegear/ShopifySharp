using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ShopifySharp.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// A standardized error code, independent of the payment provider.
    /// </summary>
    [JsonConverter(typeof(NullableEnumConverter<ShopifyTransactionError>))]
    public enum ShopifyTransactionError
    {
        [EnumMember(Value = "incorrect_number")]
        IncorrectNumber,

        [EnumMember(Value = "invalid_number")]
        InvalidNumber,

        [EnumMember(Value = "invalid_expiry_date")]
        InvalidExpiryDate,

        [EnumMember(Value = "invalid_cvc")]
        InvalidCvc,

        [EnumMember(Value = "expired_card")]
        ExpiredCard,

        [EnumMember(Value = "incorrect_cvc")]
        IncorrectCvc,

        [EnumMember(Value = "incorrect_zip")]
        IncorrectZip,

        [EnumMember(Value = "incorrect_address")]
        IncorrectAddress,

        [EnumMember(Value = "card_declined")]
        CardDeclined,

        [EnumMember(Value = "processing_error")]
        ProcesingError,
        
        [EnumMember(Value = "call_issuer")]
        CallIssuer,

        [EnumMember(Value = "pick_up_card")]
        PickUpCard
    }
}
