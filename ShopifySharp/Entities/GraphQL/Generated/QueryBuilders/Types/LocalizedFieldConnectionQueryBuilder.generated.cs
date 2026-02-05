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
    public sealed class LocalizedFieldConnectionQueryBuilder : FieldsQueryBuilderBase<LocalizedFieldConnection, LocalizedFieldConnectionQueryBuilder>
    {
        protected override LocalizedFieldConnectionQueryBuilder Self => this;

        public LocalizedFieldConnectionQueryBuilder() : this("localizedFieldConnection")
        {
        }

        public LocalizedFieldConnectionQueryBuilder(string name) : base(new Query<LocalizedFieldConnection>(name))
        {
        }

        public LocalizedFieldConnectionQueryBuilder(IQuery<LocalizedFieldConnection> query) : base(query)
        {
        }

        public LocalizedFieldConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldEdgeQueryBuilder> build)
        {
            var query = new Query<LocalizedFieldEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedFieldEdge>(query);
            return this;
        }

        public LocalizedFieldConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldQueryBuilder> build)
        {
            var query = new Query<LocalizedField>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizedFieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizedField>(query);
            return this;
        }

        public LocalizedFieldConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}