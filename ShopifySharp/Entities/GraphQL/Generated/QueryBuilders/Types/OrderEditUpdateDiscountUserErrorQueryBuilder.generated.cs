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
    public sealed class OrderEditUpdateDiscountUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderEditUpdateDiscountUserError, OrderEditUpdateDiscountUserErrorQueryBuilder>
    {
        protected override OrderEditUpdateDiscountUserErrorQueryBuilder Self => this;

        public OrderEditUpdateDiscountUserErrorQueryBuilder() : this("orderEditUpdateDiscountUserError")
        {
        }

        public OrderEditUpdateDiscountUserErrorQueryBuilder(string name) : base(new Query<OrderEditUpdateDiscountUserError>(name))
        {
        }

        public OrderEditUpdateDiscountUserErrorQueryBuilder(IQuery<OrderEditUpdateDiscountUserError> query) : base(query)
        {
        }

        public OrderEditUpdateDiscountUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderEditUpdateDiscountUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderEditUpdateDiscountUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}