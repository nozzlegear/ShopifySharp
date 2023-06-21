using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class PriceRule : ShopifyObject
    {
        /**
        * The title of the price rule.
        */
        [JsonProperty("title")]
        public string Title { get; set; }

        /**
        * The target type the price rule applies to. Known values are "line_item" or "shipping_line".
        */
        [JsonProperty("target_type")]
        public string TargetType { get; set; }

        /**
        * The target selection method of the price rule. Use all to apply the discount to all line items
        * in the checkout and use entitled to apply to selected entitlements. Known values are "all" or "entitled".
        */
        [JsonProperty("target_selection")]
        public string TargetSelection { get; set; }

        /**
        * The allocation method of the price rule.
        * With an allocation method of each, the discount will be applied to each of the entitled items. For example, for a price rule that take $15 off, each entitled line item in a checkout will be discounted by $15.
        * With an allocation method of across, the calculated discount amount will be applied across the entitled items.For example, for a price rule that takes $15 off, the discount will be applied across all the entitled items.
        * Currently, if TargetType is shipping_line, then only each is accepted. Known values are "across" or "each".
        */
        [JsonProperty("allocation_method")]
        public string AllocationMethod { get; set; }

        /**
        * The value type of the price rule. If target_type is shipping_line then only percentage is accepted. Known values are "fixed_amount" or "percentage".
        */
        [JsonProperty("value_type")]
        public string ValueType { get; set; }

        /**
        * The value of the price rule. If target_type is shipping_line, then only -100 is accepted.
        * It's important to note that when discounting a resource, the value must be a negative number.
        */
        [JsonProperty("value")]
        public decimal Value { get; set; }

        /**
        * The price rule can only be used once per customer (tracked by customer id).
        */
        [JsonProperty("once_per_customer")]
        public bool? OncePerCustomer { get; set; }

        /**
        * The maximum number of times the price rule can be used, per discount code.
        */
        [JsonProperty("usage_limit")]
        public long? UsageLimit { get; set; }

        /**
        * The customer selection for the price rule.A customer selection of all means there are no restrictions
        * on who's eligible for the price rule. Known values are "all" or "prerequisite".
        */
        [JsonProperty("customer_selection")]
        public string CustomerSelection { get; set; }

        /**
        * Prerequisite cart subtotal range.
        */
        [JsonProperty("prerequisite_subtotal_range")]
        public PrerequisiteValueRange PrerequisiteSubtotalRange { get; set; }

        /**
        * Prerequisite shipping cost range.Can only be used when target_type is shipping_line.
        */
        [JsonProperty("prerequisite_shipping_price_range")]
        public PrerequisiteValueRange PrerequisiteShippingPriceRange { get; set; }

        [JsonProperty("prerequisite_quantity_range")]
        public PrerequisiteQuantityRange PrerequisiteQuantityRange { get; set; }

        /**
        * A list of prerequisite customer saved search ids. For the price rule to be applicable,
        * the customer applying the price rule must be in the group of customers matching the customer saved searches.
        */
        [JsonProperty("prerequisite_saved_search_ids")]
        public IEnumerable<long> PrerequisiteSavedSearchIds { get; set; }

        [JsonProperty("customer_segment_prerequisite_ids")]
        public IEnumerable<long> CustomerSegmentPrerequisiteIds { get; set; }

        [JsonProperty("prerequisite_to_entitlement_purchase")]
        public PrerequisiteToEntitlementPurchase PrerequisiteToEntitlementPurchase { get; set; }

        [JsonProperty("prerequisite_product_ids")]
        public IEnumerable<long> PrerequisiteProductIds { get; set; }

        [JsonProperty("prerequisite_variant_ids")]
        public IEnumerable<long> PrerequisiteVariantIds { get; set; }

        [JsonProperty("prerequisite_collection_ids")]
        public List<object> PrerequisiteCollectionIds { get; set; }
        [JsonProperty("prerequisite_to_entitlement_quantity_ratio")]
        public PrerequisiteToEntitlementQuantityRatio PrerequisiteToEntitlementQuantityRatio { get; set; }

        [JsonProperty("allocation_limit")]
        public int AllocationLimit { get; set; }



        /**
        * A list of prerequisite customer ids. For the price rule to be applicable,
        * the customer applying the price rule must be in the group of customers specified.
        */
        [JsonProperty("prerequisite_customer_ids")]
        public IEnumerable<long> PrerequisiteCustomerIds { get; set; }

        /**
        * A list of entitled product ids.Can be used in combination with entitled_variant_ids. entitled_product_ids can
        * only be used in conjunction with target_type set to line_itemif and target_selection set to entitled
        */
        [JsonProperty("entitled_product_ids")]
        public IEnumerable<long> EntitledProductIds { get; set; }

        /**
        * A list of entitled product variant ids. Can be used in combination with entitled_product_ids.
        * entitled_variant_ids can only be used in conjunction with target_type set to line_item if and target_selection set to
        * entitled
        */
        [JsonProperty("entitled_variant_ids")]
        public IEnumerable<long> EntitledVariantIds { get; set; }

        /**
        * A list of entitled collection ids. Cannot be used in combination with entitled_product_ids nor
        * entitled_variant_ids. entitled_collection_ids can only be used in conjunction with target_typeset to line_item and
        * target_selection set to entitled
        */
        [JsonProperty("entitled_collection_ids")]
        public IEnumerable<long> EntitledCollectionIds { get; set; }



        /**
        * A list of shipping country ids. entitled_country_ids can only be used in conjunction with target_type set to
        * shipping_line and target_selection set to entitled.
        */
        [JsonProperty("entitled_country_ids")]
        public IEnumerable<long> EntitledCountryIds { get; set; }

        /**
        * The date and time when the price rule starts.
        */
        [JsonProperty("starts_at")]
        public DateTimeOffset? StartsAt { get; set; }

        /**
        * The date and time when the price rule ends.Must be after starts_at.
        */
        [JsonProperty("ends_at")]
        public DateTimeOffset? EndsAt { get; set; }

        /**
        * The date and time the object was created.
        */
        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /**
        * The date and time the object was last updated.
        */
        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
