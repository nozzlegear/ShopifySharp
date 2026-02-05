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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class MarketingActivitiesOperationQueryBuilder : FieldsQueryBuilderBase<MarketingActivityConnection, MarketingActivitiesOperationQueryBuilder>, IGraphOperationQueryBuilder<MarketingActivityConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MarketingActivitiesArgumentsBuilder Arguments { get; }
        protected override MarketingActivitiesOperationQueryBuilder Self => this;

        public MarketingActivitiesOperationQueryBuilder() : this("marketingActivities")
        {
        }

        public MarketingActivitiesOperationQueryBuilder(string name) : base(new Query<MarketingActivityConnection>(name))
        {
            Arguments = new MarketingActivitiesArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivitiesOperationQueryBuilder(IQuery<MarketingActivityConnection> query) : base(query)
        {
            Arguments = new MarketingActivitiesArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivitiesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityEdgeQueryBuilder> build)
        {
            var query = new Query<MarketingActivityEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityEdge>(query);
            return this;
        }

        public MarketingActivitiesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        public MarketingActivitiesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}