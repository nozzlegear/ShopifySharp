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
    public sealed class MarketingActivityConnectionQueryBuilder : FieldsQueryBuilderBase<MarketingActivityConnection, MarketingActivityConnectionQueryBuilder>, IHasArguments<MarketingActivityConnectionArgumentsBuilder>
    {
        public MarketingActivityConnectionArgumentsBuilder Arguments { get; }
        protected override MarketingActivityConnectionQueryBuilder Self => this;

        public MarketingActivityConnectionQueryBuilder() : this("marketingActivityConnection")
        {
        }

        public MarketingActivityConnectionQueryBuilder(string name) : base(new Query<MarketingActivityConnection>(name))
        {
            Arguments = new MarketingActivityConnectionArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityConnectionQueryBuilder(IQuery<MarketingActivityConnection> query) : base(query)
        {
            Arguments = new MarketingActivityConnectionArgumentsBuilder(base.InnerQuery);
        }

        public MarketingActivityConnectionQueryBuilder SetArguments(Action<MarketingActivityConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MarketingActivityConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityEdgeQueryBuilder> build)
        {
            var query = new Query<MarketingActivityEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivityEdge>(query);
            return this;
        }

        public MarketingActivityConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder> build)
        {
            var query = new Query<MarketingActivity>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketingActivityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketingActivity>(query);
            return this;
        }

        public MarketingActivityConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}