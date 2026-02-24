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
    public sealed class MarketLocalizableResourceConnectionQueryBuilder : FieldsQueryBuilderBase<MarketLocalizableResourceConnection, MarketLocalizableResourceConnectionQueryBuilder>, IHasArguments<MarketLocalizableResourceConnectionArgumentsBuilder>
    {
        public MarketLocalizableResourceConnectionArgumentsBuilder Arguments { get; }
        protected override MarketLocalizableResourceConnectionQueryBuilder Self => this;

        public MarketLocalizableResourceConnectionQueryBuilder() : this("marketLocalizableResourceConnection")
        {
        }

        public MarketLocalizableResourceConnectionQueryBuilder(string name) : base(new Query<MarketLocalizableResourceConnection>(name))
        {
            Arguments = new MarketLocalizableResourceConnectionArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizableResourceConnectionQueryBuilder(IQuery<MarketLocalizableResourceConnection> query) : base(query)
        {
            Arguments = new MarketLocalizableResourceConnectionArgumentsBuilder(base.InnerQuery);
        }

        public MarketLocalizableResourceConnectionQueryBuilder SetArguments(Action<MarketLocalizableResourceConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MarketLocalizableResourceConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceEdgeQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResourceEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResourceEdge>(query);
            return this;
        }

        public MarketLocalizableResourceConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResource>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResource>(query);
            return this;
        }

        public MarketLocalizableResourceConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}