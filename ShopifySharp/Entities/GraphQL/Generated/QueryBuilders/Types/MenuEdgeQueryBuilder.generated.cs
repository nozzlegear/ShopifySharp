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

        public MenuEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MenuQueryBuilder> build)
        {
            var query = new Query<Menu>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MenuQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Menu>(query);
            return this;
        }
    }
}