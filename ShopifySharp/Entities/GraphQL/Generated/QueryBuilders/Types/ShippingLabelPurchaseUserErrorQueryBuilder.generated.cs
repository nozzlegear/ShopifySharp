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
    public sealed class ShippingLabelPurchaseUserErrorQueryBuilder : FieldsQueryBuilderBase<ShippingLabelPurchaseUserError, ShippingLabelPurchaseUserErrorQueryBuilder>
    {
        protected override ShippingLabelPurchaseUserErrorQueryBuilder Self => this;

        public ShippingLabelPurchaseUserErrorQueryBuilder() : this("shippingLabelPurchaseUserError")
        {
        }

        public ShippingLabelPurchaseUserErrorQueryBuilder(string name) : base(new Query<ShippingLabelPurchaseUserError>(name))
        {
        }

        public ShippingLabelPurchaseUserErrorQueryBuilder(IQuery<ShippingLabelPurchaseUserError> query) : base(query)
        {
        }

        public ShippingLabelPurchaseUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public ShippingLabelPurchaseUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public ShippingLabelPurchaseUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}