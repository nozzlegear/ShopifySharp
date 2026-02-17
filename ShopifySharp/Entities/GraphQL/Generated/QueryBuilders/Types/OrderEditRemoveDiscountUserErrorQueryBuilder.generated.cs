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
    public sealed class OrderEditRemoveDiscountUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderEditRemoveDiscountUserError, OrderEditRemoveDiscountUserErrorQueryBuilder>
    {
        protected override OrderEditRemoveDiscountUserErrorQueryBuilder Self => this;

        public OrderEditRemoveDiscountUserErrorQueryBuilder() : this("orderEditRemoveDiscountUserError")
        {
        }

        public OrderEditRemoveDiscountUserErrorQueryBuilder(string name) : base(new Query<OrderEditRemoveDiscountUserError>(name))
        {
        }

        public OrderEditRemoveDiscountUserErrorQueryBuilder(IQuery<OrderEditRemoveDiscountUserError> query) : base(query)
        {
        }

        public OrderEditRemoveDiscountUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderEditRemoveDiscountUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderEditRemoveDiscountUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}