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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class AbandonedCheckoutsOperationQueryBuilder : FieldsQueryBuilderBase<AbandonedCheckoutConnection, AbandonedCheckoutsOperationQueryBuilder>, IGraphOperationQueryBuilder<AbandonedCheckoutConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AbandonedCheckoutsArgumentsBuilder Arguments { get; }
        protected override AbandonedCheckoutsOperationQueryBuilder Self => this;

        public AbandonedCheckoutsOperationQueryBuilder() : this("abandonedCheckouts")
        {
        }

        public AbandonedCheckoutsOperationQueryBuilder(string name) : base(new Query<AbandonedCheckoutConnection>(name))
        {
            Arguments = new AbandonedCheckoutsArgumentsBuilder(base.InnerQuery);
        }

        public AbandonedCheckoutsOperationQueryBuilder(IQuery<AbandonedCheckoutConnection> query) : base(query)
        {
            Arguments = new AbandonedCheckoutsArgumentsBuilder(base.InnerQuery);
        }

        public AbandonedCheckoutsOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutEdgeQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckoutEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckoutEdge>(query);
            return this;
        }

        public AbandonedCheckoutsOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder> build)
        {
            var query = new Query<AbandonedCheckout>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AbandonedCheckoutQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AbandonedCheckout>(query);
            return this;
        }

        public AbandonedCheckoutsOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}