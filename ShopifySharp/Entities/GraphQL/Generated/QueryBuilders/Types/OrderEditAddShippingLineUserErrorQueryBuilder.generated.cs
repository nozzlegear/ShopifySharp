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
    public sealed class OrderEditAddShippingLineUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderEditAddShippingLineUserError, OrderEditAddShippingLineUserErrorQueryBuilder>
    {
        protected override OrderEditAddShippingLineUserErrorQueryBuilder Self => this;

        public OrderEditAddShippingLineUserErrorQueryBuilder() : this("orderEditAddShippingLineUserError")
        {
        }

        public OrderEditAddShippingLineUserErrorQueryBuilder(string name) : base(new Query<OrderEditAddShippingLineUserError>(name))
        {
        }

        public OrderEditAddShippingLineUserErrorQueryBuilder(IQuery<OrderEditAddShippingLineUserError> query) : base(query)
        {
        }

        public OrderEditAddShippingLineUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderEditAddShippingLineUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderEditAddShippingLineUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}