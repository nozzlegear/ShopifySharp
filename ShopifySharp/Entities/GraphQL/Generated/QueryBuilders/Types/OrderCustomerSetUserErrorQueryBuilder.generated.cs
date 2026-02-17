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
    public sealed class OrderCustomerSetUserErrorQueryBuilder : FieldsQueryBuilderBase<OrderCustomerSetUserError, OrderCustomerSetUserErrorQueryBuilder>
    {
        protected override OrderCustomerSetUserErrorQueryBuilder Self => this;

        public OrderCustomerSetUserErrorQueryBuilder() : this("orderCustomerSetUserError")
        {
        }

        public OrderCustomerSetUserErrorQueryBuilder(string name) : base(new Query<OrderCustomerSetUserError>(name))
        {
        }

        public OrderCustomerSetUserErrorQueryBuilder(IQuery<OrderCustomerSetUserError> query) : base(query)
        {
        }

        public OrderCustomerSetUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public OrderCustomerSetUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public OrderCustomerSetUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}