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
    public sealed class PageEdgeQueryBuilder : FieldsQueryBuilderBase<PageEdge, PageEdgeQueryBuilder>
    {
        protected override PageEdgeQueryBuilder Self => this;

        public PageEdgeQueryBuilder() : this("pageEdge")
        {
        }

        public PageEdgeQueryBuilder(string name) : base(new Query<PageEdge>(name))
        {
        }

        public PageEdgeQueryBuilder(IQuery<PageEdge> query) : base(query)
        {
        }

        public PageEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public PageEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder> build)
        {
            var query = new Query<Page>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Page>(query);
            return this;
        }
    }
}