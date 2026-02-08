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
    public sealed class AppEdgeQueryBuilder : FieldsQueryBuilderBase<AppEdge, AppEdgeQueryBuilder>
    {
        protected override AppEdgeQueryBuilder Self => this;

        public AppEdgeQueryBuilder() : this("appEdge")
        {
        }

        public AppEdgeQueryBuilder(string name) : base(new Query<AppEdge>(name))
        {
        }

        public AppEdgeQueryBuilder(IQuery<AppEdge> query) : base(query)
        {
        }

        public AppEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public AppEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }
    }
}