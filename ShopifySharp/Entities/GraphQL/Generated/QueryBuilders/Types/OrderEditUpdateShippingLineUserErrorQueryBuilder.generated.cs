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
    public sealed class OrderEditUpdateShippingLineUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderEditUpdateShippingLineUserError, OrderEditUpdateShippingLineUserErrorQueryBuilder>
    {
        protected override OrderEditUpdateShippingLineUserErrorQueryBuilder Self => this;

        public OrderEditUpdateShippingLineUserErrorQueryBuilder() : this("orderEditUpdateShippingLineUserError")
        {
        }

        public OrderEditUpdateShippingLineUserErrorQueryBuilder(string name) : base(new Query<OrderEditUpdateShippingLineUserError>(name))
        {
        }

        public OrderEditUpdateShippingLineUserErrorQueryBuilder(IQuery<OrderEditUpdateShippingLineUserError> query) : base(query)
        {
        }

        public OrderEditUpdateShippingLineUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderEditUpdateShippingLineUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderEditUpdateShippingLineUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}