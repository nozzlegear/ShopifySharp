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

        public LineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder> build)
        {
            var query = new Query<LineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LineItem>(query);
            return this;
        }
    }
}