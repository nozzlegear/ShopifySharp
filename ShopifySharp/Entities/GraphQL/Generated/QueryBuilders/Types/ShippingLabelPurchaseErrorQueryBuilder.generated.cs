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
    public sealed class ShippingLabelPurchaseErrorQueryBuilder : FieldsQueryBuilderBase<ShippingLabelPurchaseError, ShippingLabelPurchaseErrorQueryBuilder>
    {
        protected override ShippingLabelPurchaseErrorQueryBuilder Self => this;

        public ShippingLabelPurchaseErrorQueryBuilder() : this("shippingLabelPurchaseError")
        {
        }

        public ShippingLabelPurchaseErrorQueryBuilder(string name) : base(new Query<ShippingLabelPurchaseError>(name))
        {
        }

        public ShippingLabelPurchaseErrorQueryBuilder(IQuery<ShippingLabelPurchaseError> query) : base(query)
        {
        }

        public ShippingLabelPurchaseErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ShippingLabelPurchaseErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ShippingLabelPurchaseErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}