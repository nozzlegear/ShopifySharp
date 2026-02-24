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
    public sealed class QueryRootMarketLocalizableResourceQueryBuilder : FieldsQueryBuilderBase<MarketLocalizableResource, QueryRootMarketLocalizableResourceQueryBuilder>, IHasArguments<QueryRootMarketLocalizableResourceArgumentsBuilder>
    {
        public QueryRootMarketLocalizableResourceArgumentsBuilder Arguments { get; }
        protected override QueryRootMarketLocalizableResourceQueryBuilder Self => this;

        public QueryRootMarketLocalizableResourceQueryBuilder(string name) : base(new Query<MarketLocalizableResource>(name))
        {
            Arguments = new QueryRootMarketLocalizableResourceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMarketLocalizableResourceQueryBuilder(IQuery<MarketLocalizableResource> query) : base(query)
        {
            Arguments = new QueryRootMarketLocalizableResourceArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootMarketLocalizableResourceQueryBuilder SetArguments(Action<QueryRootMarketLocalizableResourceArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootMarketLocalizableResourceQueryBuilder MarketLocalizableContent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableContentQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableContent>("marketLocalizableContent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizableContentQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableContent>(query);
            return this;
        }

        public QueryRootMarketLocalizableResourceQueryBuilder MarketLocalizations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizationQueryBuilder> build)
        {
            var query = new Query<MarketLocalization>("marketLocalizations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketLocalizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalization>(query);
            return this;
        }

        public QueryRootMarketLocalizableResourceQueryBuilder ResourceId()
        {
            base.InnerQuery.AddField("resourceId");
            return this;
        }
    }
}