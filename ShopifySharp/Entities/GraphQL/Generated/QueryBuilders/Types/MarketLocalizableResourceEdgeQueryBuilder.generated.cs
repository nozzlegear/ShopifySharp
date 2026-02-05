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
    public sealed class MarketLocalizableResourceEdgeQueryBuilder : FieldsQueryBuilderBase<MarketLocalizableResourceEdge, MarketLocalizableResourceEdgeQueryBuilder>
    {
        protected override MarketLocalizableResourceEdgeQueryBuilder Self => this;

        public MarketLocalizableResourceEdgeQueryBuilder() : this("marketLocalizableResourceEdge")
        {
        }

        public MarketLocalizableResourceEdgeQueryBuilder(string name) : base(new Query<MarketLocalizableResourceEdge>(name))
        {
        }

        public MarketLocalizableResourceEdgeQueryBuilder(IQuery<MarketLocalizableResourceEdge> query) : base(query)
        {
        }

        public MarketLocalizableResourceEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MarketLocalizableResourceEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder> build)
        {
            var query = new Query<MarketLocalizableResource>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MarketLocalizableResourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MarketLocalizableResource>(query);
            return this;
        }
    }
}