using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PaymentDetails
    {
        [JsonProperty("avs_result_code")]
        public string AvsResultCode { get; set; }

        [JsonProperty("credit_card_bin")]
        public string CreditCardBin { get; set; }

        [JsonProperty("cvv_result_code")]
        public string CvvResultCode { get; set; }

        [JsonProperty("credit_card_number")]
        public string CreditCardNumber { get; set; }

        [JsonProperty("credit_card_company")]
        public string CreditCardCompany { get; set; }

        [JsonProperty("credit_card_name")]
        public string CreditCardName { get; set; }

        [JsonProperty("credit_card_wallet")]
        public string CreditCardWallet { get; set; }

        [JsonProperty("credit_card_expiration_month")]
        public int? CreditCardExpirationMonth { get; set; }

        [JsonProperty("credit_card_expiration_year")]
        public int? CreditCardExpirationYear { get; set; }

        /// <summary>
        /// The name of the payment method used by the buyer to complete the order transaction.
        /// </summary>
        [JsonProperty("payment_method_name")]
        public string PaymentMethodName { get; set; }

        /// <summary>
        /// Details for payment methods that require additional buyer action to complete the order transaction.
        /// </summary>
        [JsonProperty("buyer_action_info")]
        public object BuyerActionInfo { get; set; }
    }
}
