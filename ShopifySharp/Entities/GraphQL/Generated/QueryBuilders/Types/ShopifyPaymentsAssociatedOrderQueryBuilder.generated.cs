#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ShopifyPaymentsAssociatedOrderQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsAssociatedOrder, ShopifyPaymentsAssociatedOrderQueryBuilder>
    {
        protected override ShopifyPaymentsAssociatedOrderQueryBuilder Self => this;

        public ShopifyPaymentsAssociatedOrderQueryBuilder() : this("shopifyPaymentsAssociatedOrder")
        {
        }

        public ShopifyPaymentsAssociatedOrderQueryBuilder(string name) : base(new Query<ShopifyPaymentsAssociatedOrder>(name))
        {
        }

        public ShopifyPaymentsAssociatedOrderQueryBuilder(IQuery<ShopifyPaymentsAssociatedOrder> query) : base(query)
        {
        }

        public ShopifyPaymentsAssociatedOrderQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyPaymentsAssociatedOrderQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }
    }
}