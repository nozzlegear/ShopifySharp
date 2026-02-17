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
    public sealed class OrderEditSessionQueryBuilder : FieldsQueryBuilderBase<OrderEditSession, OrderEditSessionQueryBuilder>
    {
        protected override OrderEditSessionQueryBuilder Self => this;

        public OrderEditSessionQueryBuilder() : this("orderEditSession")
        {
        }

        public OrderEditSessionQueryBuilder(string name) : base(new Query<OrderEditSession>(name))
        {
        }

        public OrderEditSessionQueryBuilder(IQuery<OrderEditSession> query) : base(query)
        {
        }

        public OrderEditSessionQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }
    }
}