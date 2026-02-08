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
    public sealed class OrderCancellationQueryBuilder : FieldsQueryBuilderBase<OrderCancellation, OrderCancellationQueryBuilder>
    {
        protected override OrderCancellationQueryBuilder Self => this;

        public OrderCancellationQueryBuilder() : this("orderCancellation")
        {
        }

        public OrderCancellationQueryBuilder(string name) : base(new Query<OrderCancellation>(name))
        {
        }

        public OrderCancellationQueryBuilder(IQuery<OrderCancellation> query) : base(query)
        {
        }

        public OrderCancellationQueryBuilder StaffNote()
        {
            base.InnerQuery.AddField("staffNote");
            return this;
        }
    }
}