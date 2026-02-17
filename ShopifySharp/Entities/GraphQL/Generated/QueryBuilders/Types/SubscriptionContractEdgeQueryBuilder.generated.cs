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
    public sealed class SubscriptionContractEdgeQueryBuilder : FieldsQueryBuilderBase<SubscriptionContractEdge, SubscriptionContractEdgeQueryBuilder>
    {
        protected override SubscriptionContractEdgeQueryBuilder Self => this;

        public SubscriptionContractEdgeQueryBuilder() : this("subscriptionContractEdge")
        {
        }

        public SubscriptionContractEdgeQueryBuilder(string name) : base(new Query<SubscriptionContractEdge>(name))
        {
        }

        public SubscriptionContractEdgeQueryBuilder(IQuery<SubscriptionContractEdge> query) : base(query)
        {
        }

        public SubscriptionContractEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SubscriptionContractEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }
    }
}