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
    public sealed class OrderEditRemoveShippingLineUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderEditRemoveShippingLineUserError, OrderEditRemoveShippingLineUserErrorQueryBuilder>
    {
        protected override OrderEditRemoveShippingLineUserErrorQueryBuilder Self => this;

        public OrderEditRemoveShippingLineUserErrorQueryBuilder() : this("orderEditRemoveShippingLineUserError")
        {
        }

        public OrderEditRemoveShippingLineUserErrorQueryBuilder(string name) : base(new Query<OrderEditRemoveShippingLineUserError>(name))
        {
        }

        public OrderEditRemoveShippingLineUserErrorQueryBuilder(IQuery<OrderEditRemoveShippingLineUserError> query) : base(query)
        {
        }

        public OrderEditRemoveShippingLineUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderEditRemoveShippingLineUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderEditRemoveShippingLineUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}