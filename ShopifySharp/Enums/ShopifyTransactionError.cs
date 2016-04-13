using Newtonsoft.Json;
using ShopifySharp.Converters;
using System.Runtime.Serialization;

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
