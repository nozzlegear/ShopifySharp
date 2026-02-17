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