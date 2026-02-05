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
    public sealed class LineItemEdgeQueryBuilder : FieldsQueryBuilderBase<LineItemEdge, LineItemEdgeQueryBuilder>
    {
        protected override LineItemEdgeQueryBuilder Self => this;

        public LineItemEdgeQueryBuilder() : this("lineItemEdge")
        {
        }

        public LineItemEdgeQueryBuilder(string name) : base(new Query<LineItemEdge>(name))
        {
        }

        public LineItemEdgeQueryBuilder(IQuery<LineItemEdge> query) : base(query)
        {
        }

        public LineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public LineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }
    }
}