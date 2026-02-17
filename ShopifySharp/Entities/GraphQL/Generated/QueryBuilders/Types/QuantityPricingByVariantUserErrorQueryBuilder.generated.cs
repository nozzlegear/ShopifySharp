#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QuantityPricingByVariantUserErrorQueryBuilder : FieldsQueryBuilderBase<QuantityPricingByVariantUserError, QuantityPricingByVariantUserErrorQueryBuilder>
    {
        protected override QuantityPricingByVariantUserErrorQueryBuilder Self => this;

        public QuantityPricingByVariantUserErrorQueryBuilder() : this("quantityPricingByVariantUserError")
        {
        }

        public QuantityPricingByVariantUserErrorQueryBuilder(string name) : base(new Query<QuantityPricingByVariantUserError>(name))
        {
        }

        public QuantityPricingByVariantUserErrorQueryBuilder(IQuery<QuantityPricingByVariantUserError> query) : base(query)
        {
        }

        public QuantityPricingByVariantUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public QuantityPricingByVariantUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public QuantityPricingByVariantUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}