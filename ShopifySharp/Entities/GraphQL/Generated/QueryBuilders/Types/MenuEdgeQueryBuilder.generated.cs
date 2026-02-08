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
    public sealed class MenuEdgeQueryBuilder : FieldsQueryBuilderBase<MenuEdge, MenuEdgeQueryBuilder>
    {
        protected override MenuEdgeQueryBuilder Self => this;

        public MenuEdgeQueryBuilder() : this("menuEdge")
        {
        }

        public MenuEdgeQueryBuilder(string name) : base(new Query<MenuEdge>(name))
        {
        }

        public MenuEdgeQueryBuilder(IQuery<MenuEdge> query) : base(query)
        {
        }

        public MenuEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public MenuEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Menu>(query);
            return this;
        }
    }
}