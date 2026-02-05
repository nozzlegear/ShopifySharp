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
    public sealed class StringConnectionQueryBuilder : FieldsQueryBuilderBase<StringConnection, StringConnectionQueryBuilder>
    {
        protected override StringConnectionQueryBuilder Self => this;

        public StringConnectionQueryBuilder() : this("stringConnection")
        {
        }

        public StringConnectionQueryBuilder(string name) : base(new Query<StringConnection>(name))
        {
        }

        public StringConnectionQueryBuilder(IQuery<StringConnection> query) : base(query)
        {
        }

        public StringConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringEdgeQueryBuilder> build)
        {
            var query = new Query<StringEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StringEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StringEdge>(query);
            return this;
        }

        public StringConnectionQueryBuilder Nodes()
        {
            base.InnerQuery.AddField("nodes");
            return this;
        }

        public StringConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}