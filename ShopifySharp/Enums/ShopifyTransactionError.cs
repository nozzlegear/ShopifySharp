using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp.Enums
{
    /// <summary>
    /// A standardized error code, independent of the payment provider.
    /// </summary>
    public enum ShopifyTransactionError
    {
        [JsonProperty("incorrect_number")]
        IncorrectNumber,

        [JsonProperty("invalid_number")]
        InvalidNumber,

        [JsonProperty("invalid_expiry_date")]
        InvalidExpiryDate,

        [JsonProperty("invalid_cvc")]
        InvalidCvc,

        [JsonProperty("expired_card")]
        ExpiredCard,

        [JsonProperty("incorrect_cvc")]
        IncorrectCvc,

        [JsonProperty("incorrect_zip")]
        IncorrectZip,

        [JsonProperty("incorrect_address")]
        IncorrectAddress,

        [JsonProperty("card_declined")]
        CardDeclined,

        [JsonProperty("processing_error")]
        ProcesingError,
        
        [JsonProperty("call_issuer")]
        CallIssuer,

        [JsonProperty("pick_up_card")]
        PickUpCard
    }
}
